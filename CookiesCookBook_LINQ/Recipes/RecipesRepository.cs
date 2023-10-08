using CookiesCookBook_LINQ.DataAccess;
using CookiesCookBook_LINQ.Recipes;

public class RecipesRepository : IRecipesRepository
{
    private readonly IStringsRepository _stringsRepository;
    private readonly IIngredientsRegister _ingredientsRegister;
    private const string Separator = ",";

    public RecipesRepository(IStringsRepository stringsRepository, IIngredientsRegister ingredientsRegister)
    {
        _stringsRepository = stringsRepository;
        _ingredientsRegister = ingredientsRegister;
    }

    public List<Recipe> Read(string filePath)
    {
        //reads repository strings from repository and transforms each of them in Recipe object
        //return recipesFromFile.Select(recipeFromFile => RecipeFromString(recipeFromFile));
        return _stringsRepository.Read(filePath)
            .Select(RecipeFromString)
            .ToList(); //short version

    }

    private Recipe RecipeFromString(string recipeFromFile)
    {
        //separate with separator
        var ingredients = recipeFromFile.Split(Separator)
            .Select(int.Parse) //transform result substrings into ints
            .Select(_ingredientsRegister.GetById); // use them to get ingredient with coresponding id, creating collection of ingredients

        return new Recipe(ingredients);
    }

    public void Write(string filePath, List<Recipe> allRecipes)
    {
        var recipesAsStrings = allRecipes
            .Select(recipe =>
            {
                var allIds = recipe.Ingredients.Select(ingredient => ingredient.Id);
                return string.Join(Separator, allIds);
            });
      
        _stringsRepository.Write(filePath, recipesAsStrings.ToList());
        
    }
}

