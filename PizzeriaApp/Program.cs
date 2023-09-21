using PizzeriaApp;
using PizzeriaApp.Interfaces;
using System.Text.Json;

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
//    new Cheddar(12,2),
//    new Mozzarella(3),
//    new TomatoSauce(4)
//};



//foreach (Ingredient ingridient in ingredients)
//{
//    Console.WriteLine(ingridient.Name);
//}

var person = new Person
{
    FirstName = "John",
    LastName = "Smith",
    YearOfBirth = 1972
};
//Serialize pretvaranje C# koda u JSON
var asJson = JsonSerializer.Serialize(person);
Console.WriteLine("As JSON:");
Console.WriteLine(asJson);

var personJson =
    "{\"FirstName\":\"John\",\"LastName\":\"Smith\",\"YearOfBirth\":1972}";
//Deserialize pretvaranje iz JSONa u c# code
var personFromJson = JsonSerializer.Deserialize<Person>(personJson);


//moraju imati isti type objecti u listi

var bakeableDishes = new List<IBakeable>
{
    new Pizza(),
    new Panettone()
};

foreach (var item in bakeableDishes)
{
    Console.WriteLine(item.GetInstructions());
}



Console.ReadKey();

public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int YearOfBirth { get; set; }
}

