
using static System.Runtime.InteropServices.JavaScript.JSType;

class Person
{
    public string Name { get; init; }
    public int Age { get; init; }

    //Finalizer/Destructor ~, always paramiterless
    ~Person()
    {
        Console.WriteLine($"Person called {Name} is being destructed");
    }

    //protected override void Finalize() //-- do not override object.Finalize.Instead, provide a destructor.
    //{
    //    Console.WriteLine($"Person called {Name} is being destructed");
    //}
}
