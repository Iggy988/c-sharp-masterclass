using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodsExample.Extensions;

public static class SeasonExtensions
{
    public static Season Next(this Season season)
    {
        int seasonAsInt = (int)season;
        int nextSeason = (seasonAsInt + 1) % 4;
        return (Season)nextSeason;
    }
}
