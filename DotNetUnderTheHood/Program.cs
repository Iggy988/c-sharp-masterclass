int number = 5;
int anotherNumber = number;
anotherNumber++;

Console.WriteLine("Number is " + number);
Console.WriteLine("AnotherNumber is " + anotherNumber);

var john = new Person { Name = "John", Age = 34 };
var person = john;
//person.Age = 36;

AddOneToNumber(ref number);
AddOneToPersonAge(john);
Console.WriteLine("Number now is " + number);
Console.WriteLine("Johns age now is " + john.Age);

//classes has references semantics
// 2 variables can hold a reference to the same object
Console.WriteLine("Johns age is " + john.Age);
Console.WriteLine("Persons age is " + person.Age);

int otherNumber = 15;
MethodWithOutParameter(out otherNumber);
Console.WriteLine("other number is " + otherNumber);

var list = new List<int> { 1,2,3,4};
AddOneToList(ref list);

var variousObjects = new List<object>
{
    1,
    1.5m,
    new DateTime(2024, 6, 2),
    "hello",
    new Person{Name = "Iggy", Age = 25}
};

foreach (object someObject in variousObjects)
{
    Console.WriteLine(someObject.GetType().DeclaringType);
}

Console.ReadKey();

//list is a class, so a reference type
void AddOneToList(ref List<int> numbers)
{
    numbers = null;
}

//ref -> reference
void AddOneToNumber(ref int number)
{
    ++number;
}

void MethodWithOutParameter(out int number)
{
    number = 10;
}

//void AddOneToPersonAge(Person person)
//{
//    ++person.Age;
//}

Person AddOneToPersonAge(Person person)
{
    return new Person { Name = person.Name, Age = person.Age + 1 };
}
