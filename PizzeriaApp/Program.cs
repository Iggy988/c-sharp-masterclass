
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

//var ingredients = new List<Ingredient>
//{
 //  new Cheddar(),
 //   new Mozzarella(),
 //   new TomatoSauce()
//};

//foreach (Ingredient ingridient in ingredients)
//{
//    Console.WriteLine(ingridient.Name);
//}
		

var ingredients = new Ingredients(1);

var cheddar = new Cheddar(3, 10); // poziva constructora prvo iz basse class, onda iz derivate
Console.WriteLine(cheddar);

Console.ReadKey();

public class Pizza
{
    private List<Ingredient> _ingredients = new List<Ingredient>();
    public void AddIngredient(Ingredient ingredient) => _ingredients.Add(ingredient);
    public override string ToString() => $"This is a pizza with {string.Join(", ", _ingredients)}";
}



//Polymorphism - the provision of a single interface to entities of different tupes
//Virtual - methods or properties may be overriden by the inheriting types

public class Ingredient
{
    public Ingredient(int priceIfExtraTopping)
    {
        Console.WriteLine("Constructor from the Ingredient class");
        PriceIfExtraTopping = priceIfExtraTopping;
    }
    
    public int PublicField;

    public int PriceIfExtraTopping {get;}
    public string override ToString() => Name;
    public virtual string Name { get; } = "Some ingredient";
    public string PublicMethod() => "This is PUBLIC method of base class";
    // protected can be used in dervated classes but cannot be used outside
    protected string ProtectedMethod() => "This is PROTECTED method of base class";
    private string PrivateMethod() => "This is PRIVATE method of base class";

}

public class Cheese : Ingredient
{
    public Cheese(int priceIfExtraTopping) : base(int priceIfExtraTopping)
    {
        
    }
}

public class Cheddar : Ingredient
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
}

public class TomatoSauce : Ingredient
{
    public TomatoSauce(int priceIfExtraTopping) : base(int priceIfExtraTopping)
    {
        
    }
    public string Name => "Tomato Sauce";
    public int TomatosIn100Grams { get; }
}

public class ItalianFoodItem
{

}

public class Mozzarella : Cheese //, ItalianFoodItem - ne moze multiple inheritance
{
    public Mozzarella(int priceIfExtraTopping) : base(int priceIfExtraTopping)
    {
        
    }
    public override string Name => "Mozarella";
    public bool IsLight { get; }
}
