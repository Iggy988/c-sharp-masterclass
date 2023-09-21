using PizzeriaApp;

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

//moraju imati isti type objecti u listi
var bakeableDishes = new List<object>
{
    new Pizza(),
    new Panettone()
};

Console.ReadKey();

