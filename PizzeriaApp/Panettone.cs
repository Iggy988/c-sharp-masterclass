using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzeriaApp.Interfaces;

namespace PizzeriaApp;

public class Panettone : Dessert, IBakeable
{
    public string GetInstructions()
    {
        return "Bake at 180 degrees Celsius for 3 minutes";
    }
}
