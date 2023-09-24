namespace CookiesCookbook.Recipes;

public class Recipe
{
    //IEnumerable - for iteration (foreach)
    //Generic types and methods are parameterized by types
    public IEnumerable<Ingredient> Ingredients { get; }
    public Recipe(IEnumerable<Ingredient> ingredients)
    {
        Ingredients = ingredients;
    }

    public override string ToString()
    {
        var step = new List<string>();
        foreach (var ingredient in Ingredients)
        {
            step.Add($"{ingredient.Name}. {ingredient.PreparationInstructions}");
        }
        return string.Join(Environment.NewLine, step);
    }
}
