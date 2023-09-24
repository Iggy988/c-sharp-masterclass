

using CookiesCookbook.Recipes;
using CookiesCookbook.Recipes.Ingredients;

var cookiesRecepiesApp = new CookiesRecipesApp(
    new RecipesRepository(),
    new RecipesConsoleUserInteraction(new IngredientsRegister()));

cookiesRecepiesApp.Run("Recipe.txt");


public class CookiesRecipesApp
{

    private readonly IRecipesRepository _recipesRepository;

    private readonly IRecipesUserInteraction _recipesUserInteraction /*= new() - ne mozemo instancirati interface*/;

    //Coupling is the degree of interpendence between classes, a measure of how closely they are connected. -makes classes less usable (ne moze se koristiti jedna bez druge)

    //Dependency Inversion Principle(DIP) - high-level modules should not depend on low lewel modules; both should depend on abstractions (in C# -interfaces).

    //Dependency Injection means the class is given the dependencies it needs; it doesn't create them self

    //Design pattern - typical solution to a commonly occurring problem in software design.
    public CookiesRecipesApp(IRecipesRepository recipesRepository, IRecipesUserInteraction recipesUserInteraction)
    {
        _recipesRepository = recipesRepository;
        _recipesUserInteraction = recipesUserInteraction;
    }

    public void Run(string filePath)
    {
        var allRecipes = _recipesRepository.Read(filePath);
        _recipesUserInteraction.PrintExistingRecipes(allRecipes);

        _recipesUserInteraction.PromptToCreateRecipe();

        //var ingredients = _recipesUserInteraction.ReadIngredientsFromUser();

        //if (ingredients.Count() > 0)
        //{
        //    var recipe = new Recipe(ingredients);
        //    allRecipes.Add(recipe);
        //    _recipesRepository.Write(filePath, allRecipes);

        //    _recipesUserInteraction.ShowMessage("Recipe added:");
        //    _recipesUserInteraction.ShowMessage(recipe.ToString());
        //}
        //else
        //{
        //    _recipesUserInteraction.ShowMessage(
        //        "No ingredients have been selected. " +
        //        "Recipe will not be saved.");
        //}

        _recipesUserInteraction.Exit();

    }

}

public interface IRecipesRepository
{
    List<Recipe> Read(string filePath);
}



public interface IRecipesUserInteraction
{
    public void ShowMessage(string message);

    public void Exit();
    void PrintExistingRecipes(IEnumerable<Recipe> allRecipes);
    void PromptToCreateRecipe();
}



public class RecipesRepository : IRecipesRepository
{
    public List<Recipe> Read(string filePath)
    {
        return new List<Recipe>
        {
            new Recipe(new List<Ingredient>
            {
                new WheatFlour(),
                new Butter(),
                new Sugar()
            }),
            new Recipe(new List<Ingredient>
            {
                new CocoaPowder(),
                new SpeltFlour(),
                new Cinnamon()
            })
        };
    }
}

public class IngredientsRegister
{
    public IEnumerable<Ingredient> All { get; } = new List<Ingredient>
    {
        new WheatFlour(),
        new SpeltFlour(),
        new Butter(),
        new Chocolate(),
        new Sugar(),
        new Cardamom(),
        new Cinnamon(),
        new CocoaPowder()
    };
}

public class RecipesConsoleUserInteraction : IRecipesUserInteraction
{
    private readonly IngredientsRegister _ingredientsRegister;
    public RecipesConsoleUserInteraction(IngredientsRegister ingredientsRegister)
    {
        _ingredientsRegister = ingredientsRegister;
    }
    public void ShowMessage(string message)
    {
        Console.WriteLine(message);
    }

    public void Exit()
    {
        Console.WriteLine("Press any key to close.");
        Console.ReadKey();
    }

    public void PrintExistingRecipes(IEnumerable<Recipe> allRecipes)
    {
        if (allRecipes.Count() > 0)
        {
            Console.WriteLine("Existing recipes are: " + Environment.NewLine);

            var counter = 1;
            foreach (Recipe recipe in allRecipes) 
            {
                Console.WriteLine($"****{counter}****");
                Console.WriteLine(recipe);
                Console.WriteLine();
                ++counter;
            }
        }
    }

    public void PromptToCreateRecipe()
    {
        Console.WriteLine("Create a new cookie recipe! " + "Available ingredients are:");

        foreach (var ingredient in _ingredientsRegister.All)
        {
            Console.WriteLine(ingredient.Id + ". " +  ingredient.Name);
        }
    }
}