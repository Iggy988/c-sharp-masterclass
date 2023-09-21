using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodsExample.Extensions;

//Extension methods can only be defin in static classes, and allways are static
//Extension methods allow us to seemingly add methods to an existing type without modifiying this type's source code.
//parameter that method take is of type that we want to extend (string in this case)
public static class StringExtensions
{
    public static int CountLines(this string input) =>
        input.Split(Environment.NewLine).Length;
}
