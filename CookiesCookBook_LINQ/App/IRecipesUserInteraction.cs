
using CookiesCookBook_LINQ.Recipes;

namespace CookiesCookBook_LINQ.App;

public interface IRecipesUserInteraction
{
    public void ShowMessage(string message);

    public void Exit();
    void PrintExistingRecipes(IEnumerable<Recipe> allRecipes);
    void PromptToCreateRecipe();
    IEnumerable<Ingredient> ReadIngredientsFromUser();
    //void PrintExistingRecipes(List<Recipe> allRecipes);
}
