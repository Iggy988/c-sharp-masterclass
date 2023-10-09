int number = 5;
int anotherNumber = number;
anotherNumber++;

Console.WriteLine("Number is " + number);
Console.WriteLine("AnotherNumber is " + anotherNumber);

var john = new Person { Name ="John", Age= 34};
var person = john;
//person.Age = 36;

AddOneToNumber(number);
AddOneToPersonAge(john);
Console.WriteLine("Number now is " + number);
Console.WriteLine("Johns age now is " + john.Age);

//classes has references semantics
// 2 variables can hold a reference to the same object
Console.WriteLine("Johns age is " + john.Age);
Console.WriteLine("Persons age is " + person.Age);

Console.ReadKey();

void AddOneToNumber(int number)
{
    ++number;
}

void AddOneToPersonAge(Person person)
{
    ++person.Age;
}

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}
