namespace CookiesCookbook.Recipes.Ingredients;

public class Recipe
{
    //IEnumerable - for iteration (foreach)
    //Generic types and methods are parameterized by types
    public IEnumerable<Ingredient> Ingredients { get; }
    public Recipe(IEnumerable<Ingredient> ingredients)
    {
        Ingredients = ingredients;
    }
}
