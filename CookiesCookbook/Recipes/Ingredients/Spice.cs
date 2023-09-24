using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookiesCookbook.Recipes.Ingredients;

public abstract class Spice : Ingredient
{
    public override string PreparationInstructions =>
        $"Sieve. {base.PreparationInstructions}";
}
