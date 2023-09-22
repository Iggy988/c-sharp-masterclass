

var cookiesRecepiesApp = new CookiesRecipesApp(
    new RecipesRepository(),
    new RecipesConsoleUserInteraction());

cookiesRecepiesApp.Run();


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

        var ingredients = _recipesUserInteraction.ReadIngredientsFromUser();

        if (ingredients.Count() > 0)
        {
            var recipe = new Recipe(ingredients);
            allRecipes.Add(recipe);
            _recipesRepository.Write(filePath, allRecipes);

            _recipesUserInteraction.ShowMessage("Recipe added:");
            _recipesUserInteraction.ShowMessage(recipe.ToString());
        }
        else
        {
            _recipesUserInteraction.ShowMessage(
                "No ingredients have been selected. " +
                "Recipe will not be saved.");
        }

        _recipesUserInteraction.Exit();

    }

}

public interface IRecipesRepository
{



}



public interface IRecipesUserInteraction
{
    public void ShowMessage(string message);

    public void Exit();
}



public class RecipesRepository : IRecipesRepository
{

}



public class RecipesConsoleUserInteraction : IRecipesUserInteraction
{
    public void ShowMessage(string message)
    {
        Console.WriteLine(message);
    }

    public void Exit()
    {
        Console.WriteLine("Press any key to close.");
        Console.ReadKey();
    }
}