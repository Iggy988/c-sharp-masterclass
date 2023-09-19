
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

var ingredients = new List<Ingredient>
{
    new Cheddar(),
    new Mozzarella(),
    new TomatoSauce()
};



foreach (Ingredient ingridient in ingredients)
{
    Console.WriteLine(ingridient.Name);
}



Console.ReadKey();

public class Pizza
{
    private List<Ingredient> _ingredients = new List<Ingredient>();
    public void AddIngredient(Ingredient ingredient) => _ingredients.Add(ingredient);
    public string Describe() => $"This is a pizza with {string.Join(", ", _ingredients)}";
}



//Polymorphism - the provision of a single interface to entities of different tupes
//Virtual - methods or properties may be overriden by the inheriting types

public class Ingredient
{
    public int PublicField;
    public virtual string Name { get; } = "Some ingredient";
    public string PublicMethod() => "This is PUBLIC method of base class";
    // protected can be used in dervated classes but cannot be used outside
    protected string ProtectedMethod() => "This is PROTECTED method of base class";
    private string PrivateMethod() => "This is PRIVATE method of base class";

}

public class Cheese : Ingredient
{

}

public class Cheddar : Cheese
{
    public override string Name => "Cheddar cheese";
    public int AgedForMonth { get; }
    public void UseMethodsFromBaseClass()
    {
        Console.WriteLine(PublicMethod());
        Console.WriteLine(ProtectedMethod());
        //Console.WriteLine(PrivateMethod());
    }
}

public class TomatoSauce : Cheese
{
    public string Name => "Tomato Sauce";
    public int TomatosIn100Grams { get; }
}

public class ItalianFoodItem
{

}

public class Mozzarella : Cheese //, ItalianFoodItem - ne moze multiple inheritance
{
    public override string Name => "Mozarella";
    public bool IsLight { get; }
}