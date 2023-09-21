﻿//var pizza = new Pizza();

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
Ingredient randomIngredient = GeneratingRandomIngredient();
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

    //Cheddar cheddar = (Cheddar)randomIngredient;	
    //    Console.WriteLine("cheddar object: " + cheddar);
    //}

    //var pizza = new Pizza();
    //Console.WriteLine(pizza.number);
    //Console.WriteLine(pizza.date);

    //int ne moze biti assigned null
    //mora biti implicitly typed, ne moze var, zato sto compiler ne moze da odredi type
    Ingredient nullIngredient = null;
    if (nullIngredient is not null)
    {
        Console.WriteLine(nullIngredient.Name);
    }

    //as operator ne moze na int
    //Cheddar cheddar = (Cheddar)ingredient; - throw exception if falls
    //var ingredient = new Ingredient(1);
    //Cheddar cheddar = ingredient as Cheddar; //- result will be null if it falls

    //if (cheddar is not null)
    //{
    //    Console.WriteLine(cheddar.Name);
    //}
    //else
    //{
    //    Console.WriteLine("Conversion failed");
    //}

    var ingredients = new List<Ingredient>
{
    //new Cheddar(2,10),
    new Mozzarella(2),
    new TomatoSauce(1)
};
    foreach (Ingredient ingridient in ingredients)
    {
        ingridient.Prepare();
    }

    var pizza = RandomPizzaGenerator.Generate(3);




    Console.ReadKey();



    Ingredient GeneratingRandomIngredient()
    {
        var random = new Random();
        var number = random.Next(1, 4);
        if (number == 1) { return new Cheddar(2, 13); }
        if (number == 2) { return new TomatoSauce(1); }
        else return new Mozzarella(2);
    }
