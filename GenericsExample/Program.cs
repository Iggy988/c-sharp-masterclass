
//By using generic types, we can define the behavior of a type(List etc.),
//once and reuse it for multiple types, reducing the amount of code we need to write
var numbers = new List<int> { 1, 2, 3, 4, 5 };
var words = new List<string> { "ime", "prezime", "godina"};
var dates = new List<DateTime> { new DateTime(day: 12, month: 3, year: 2023)};

Console.ReadKey();
