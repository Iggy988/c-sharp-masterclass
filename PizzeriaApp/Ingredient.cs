//var pizza = new Pizza();

//pizza.AddIngredient(new Cheddar());

//pizza.AddIngredient(new Mozarella());

//pizza.AddIngredient(new TomatoSauce());

//Console.WriteLine(pizza.Describe());

//var ingredient = new Ingredient();

//ingredient.PublicField = 10;

//Console.WriteLine(ingredient.PublicField);

//var cheddar = new Cheddar();

//Console.WriteLine(cheddar.PublicMethod());

//Console.WriteLine(cheddar.Name);
//Ingredient ingredient = new Cheddar();

//Console.WriteLine(cheddar.ProtectedMethod());

//Console.WriteLine(cheddar.PrivateMethod());

//Console.WriteLine(ingredient.Name);

//implicit conversion -> safe int to decimal etc. int a = 10; decimal b = a;
//explicit conversion -> not safe, decimal to int, decimal c = 10.01m; int d = (int)c;
//ToString()
//upcasting => when we convert derived class to base class
//downcast => when we convert derived class to base class
//is operator - checks if some object is of a given type

//int secondSeasonNumber = 1;
//Season summer = (Season)secondSeasonNumber;
//Console.WriteLine(summer);

//var ingredients = new Ingredient(1);

//var cheddar = new Cheddar(3, 10); // poziva constructora prvo iz basse class, onda iz derivate

//Ingredient ingredient = new Cheddar(2, 12);
// pokazivace exception dok random obj ne bude type Cheddar
//Console.WriteLine("Random ingredient is " + randomIngredient);
/*
Console.WriteLine("is object? " + (ingredient is object)); //true
Console.WriteLine("is ingredient? " + (ingredient is object)); //true
Console.WriteLine("is cheddar? " + (ingredient is Cheddar)); //true
Console.WriteLine("is mozzarella? " + (ingredient is Mozzarella)); //false
Console.WriteLine("is tomato suce? " + (ingredient is TomatoSauce)); //false
*/
//if (randomIngredient is Cheddar cheddar)

//Polymorphism - the provision of a single interface to entities of different tupes
//Virtual - methods or properties may be overriden by the inheriting types
//Abstract classes cannot be instantiated. They only serve as base classes for other, more concrete types.
//Method with virtual modiffier must have an implementation, overriding is optional
//Method with abstract modiffier can't have an implementation, overriding is oblifatory

namespace PizzeriaApp
{
    public abstract class Ingredient
    {
        public Ingredient(int priceIfExtraTopping)
        {
            Console.WriteLine("Constructor from the Ingredient class");
            PriceIfExtraTopping = priceIfExtraTopping;
        }

        public int PriceIfExtraTopping { get; }

        public override string ToString() => Name;

        public virtual string Name { get; } = "Some ingredient";

        public string PublicMethod() => "This is PUBLIC method of base class";
        // protected can be used in dervated classes but cannot be used outside
        protected string ProtectedMethod() => "This is PROTECTED method of base class";

        private string PrivateMethod() => "This is PRIVATE method of base class";
        //abstract methods - Implicitly virtual. Must be overriden in non-abstract derived classes
        //nikad nece biti executed zato sto ce biti ovveriden, nema poente da ima body
        public abstract void Prepare();

        public int PublicField;

    }
}