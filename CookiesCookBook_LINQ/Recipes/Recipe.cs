namespace CookiesCookBook_LINQ.Recipes;

public class Recipe
{
    //Generic types and methods are parameterized by types
    public IEnumerable<Ingredient> Ingredients { get; }
    public Recipe(IEnumerable<Ingredient> ingredients)
    {
        Ingredients = ingredients;
    }

    public override string ToString()
    {
        var step = Ingredients
            .Select(ingre => $"{ingre.Name}. {ingre.PreparationInstructions}");
            
       
        return string.Join(Environment.NewLine, step);
    }
}
