

namespace CookiesCookbook.Recipes.Ingredients;

public abstract class Spice : Ingredient
{
    public override string PreparationInstructions =>
        $"Sieve. {base.PreparationInstructions}";
}
