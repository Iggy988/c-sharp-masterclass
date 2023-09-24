using CookiesCookbook.Recipes;

namespace CookiesCookbook.App;

public interface IRecipesUserInteraction
{
    public void ShowMessage(string message);

    public void Exit();
    void PrintExistingRecipes(IEnumerable<Recipe> allRecipes);
    void PromptToCreateRecipe();
    IEnumerable<Ingredient> ReadIngredientsFromUser();
}
