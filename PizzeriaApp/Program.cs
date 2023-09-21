
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

inr secondSeasonNumber = 1;
Season summer = (Season)secondSeasonNumber;
Console.WriteLine(summer);

//var ingredients = new Ingredient(1);

//var cheddar = new Cheddar(3, 10); // poziva constructora prvo iz basse class, onda iz derivate

Ingredient ingredient = new Cheddar(2,12);
Ingredient randomIngredient = GeneratingRandomIngredient();
// pokazivace exception dok random obj ne bude type Cheddar
Console.WriteLine("Random ingredient is " +  randomIngredient); 
/*
Console.WriteLine("is object? " + (ingredient is object)); //true
Console.WriteLine("is ingredient? " + (ingredient is object)); //true
Console.WriteLine("is cheddar? " + (ingredient is Cheddar)); //true
Console.WriteLine("is mozzarella? " + (ingredient is Mozzarella)); //false
Console.WriteLine("is tomato suce? " + (ingredient is TomatoSauce)); //false
*/
if (randomIngredient is Cheddar cheddar)
{
	//Cheddar cheddar = (Cheddar)randomIngredient;	
	Console.WriteLine("cheddar object: " + cheddar);
}

var pizza = new Pizza();
Console.WriteLine(pizza.number);
Console.WriteLine(pizza.date);

//int ne moze biti assigned null
//mora biti implicitly typed, ne moze var, zato sto compiler ne moze da odredi type
Ingredient nullIngredient = null;
if(nullIngredient is not null)
{
	Console.WriteLine(nullIngredient.Name);
}

//as operator ne moze na int
//Cheddar cheddar = (Cheddar)ingredient; - throw exception if falls
var ingredient = new Ingredient(1);
Cheddar cheddar = ingredient as Cheddar; //- result will be null if it falls

if(cheddar is not null)
{
	Console.WriteLine(cheddar.Name);
}
else 
{
	Console.WriteLine("Conversion failed");
}

var ingredients = new List<Ingredient>
{
   new Cheddar(2,10),
    new Mozzarella(2),
    new TomatoSauce(1)
};
foreach (Ingredient ingridient in ingredients)
{
    ingridient.Prepare();
}

var pizza = RandomPizzaGenerator.Generate(3);

Console.ReadKey();

public enum Season
{
	Spring,
 	Summer,
	Autumn,
 	Winter
}

Ingredient GeneratingRandomIngredient()
{
	var random = new Random();
	var number = random.Next(1, 4);
	if(number == 1){return new Cheddar(2,13);}
	if(number == 2){return new TomatoSauce(1);}
	else return new Mozzarella(2)
}

public class Pizza
{
	public Ingredient ingredient;
	public int number;
	public DateTime date;
    private List<Ingredient> _ingredients = new List<Ingredient>();
    public void AddIngredient(Ingredient ingredient) => _ingredients.Add(ingredient);
    public override string ToString() => $"This is a pizza with {string.Join(", ", _ingredients)}";
}



//Polymorphism - the provision of a single interface to entities of different tupes
//Virtual - methods or properties may be overriden by the inheriting types
//Abstract classes cannot be instantiated. They only serve as base classes for other, more concrete types.
//Method with virtual modiffier must have an implementation, overriding is optional
//Method with abstract modiffier can't have an implementation, overriding is oblifatory
public abstract class Ingredient
{
    public Ingredient(int priceIfExtraTopping)
    {
        Console.WriteLine("Constructor from the Ingredient class");
        PriceIfExtraTopping = priceIfExtraTopping;
    }
    
    public int PriceIfExtraTopping {get;}
	
    public string override ToString() => Name;
	
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
//all static classes are implicitly sealed - cannot have classee derived from them
public static class RandomPizzaGenerator
{
    public static Pizza Generate(int howManyIngredients)
    {
        var pizza = new Pizza();
        for (int i = 0; i < howManyIngredients; ++i)
        {
            var randomIngredient = GenerateRandomIngredient();
            pizza.AddIngredient(randomIngredient);
        }
        return pizza;
    }

    private static Ingredient GenerateRandomIngredient()
    {
        var random = new Random();
        var number = random.Next(1, 4);
        if (number == 1) { return new Cheddar(2, 12); }
        if (number == 2) { return new TomatoSauce(1); }
        else return new Mozzarella(2);
    }
}

public class Cheese : Ingredient
{
    public Cheese(int priceIfExtraTopping) : base(int priceIfExtraTopping)
    {
        
    }
     public override void Prepare() => Console.WriteLine("Grate and sprinkle over pizza.");
}
//we can only skip overriding the avstract method from the base class if the derived class in abstract itself.
public abstract class Cheddar : Ingredient
{

    public Cheddar(int priceIfExtraTopping, int agedForMonths) : base(int priceIfExtraTopping)
    {
        Console.WriteLine("Constructor from the Cheddar class");
        AgedForMonth = agedForMonths;
    }
    
    public override string Name => $"{base.Name}, more specifically, " + $"a Cheddar cheese aged for {AgedForMonth} months";
    public int AgedForMonth { get; }
    public void UseMethodsFromBaseClass()
    {
        Console.WriteLine(PublicMethod());
        Console.WriteLine(ProtectedMethod());
        //Console.WriteLine(PrivateMethod());
    }
     public override void Prepare() => Console.WriteLine("Slice thinly and place on top of the pizza.");
}

public class TomatoSauce : Ingredient
{
    public TomatoSauce(int priceIfExtraTopping) : base(int priceIfExtraTopping)
    {
        
    }
    public string Name => "Tomato Sauce";
    public int TomatosIn100Grams { get; }
// only virtual overriden methods can be sealed
    public sealed override void Prepare() => Console.WriteLine("Cook tomatos with basil, garlic and salt. Spread on pizza.");
}

public class SpecialTomatoSauce : TomatoSauce
{
    public SpecialTomatoSauce(int priceIfExtraTopping) : base(priceIfExtraTopping)
    {
    }
// ne mozemo zato so je sealed
    //public override void Prepare() =>
    //    Console.WriteLine("Special tomato sauce");
}

public class ItalianFoodItem
{

}

// class can't be derive from sealed type classes 
//class NewMozzarella : Mozzarella (ne moze)
public sealed class Mozzarella : Cheese //, ItalianFoodItem - ne moze multiple inheritance
{
    public Mozzarella(int priceIfExtraTopping) : base(int priceIfExtraTopping)
    {
        
    }
    public override string Name => "Mozarella";
    public bool IsLight { get; }

    public override void Prepare() => Console.WriteLine("Slice thinly and place on top of the pizza.");

	
}
