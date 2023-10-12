using System.Collections;

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


IComparable<int> intAsComparable = number;
// boxing - process of wrapping a value type into an instance of System.Object, which is reference type
// boxing happens implicitly each time we assign a value type to an instance of reference type 
object boxedNumber = number;
// unboxing is converting boxed value back to the value type - explicitly
int unboxNumber = (int)boxedNumber;

var numbers1 = new List<int> { 1, 2, 3, 4, 5 };
var numbers2 = new ArrayList { 1, 2, 3, 4, 5 }; // memory consuming zato sto mora raditi boxing operations on value types (ints)

var numbers3 = new List<IComparable<int>> { 1, 2, 3, 4, 5 }; // i ovdje se koristi boxing IComparable ref type

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
    Console.WriteLine(someObject.GetType().Name);
}


//string userInput = Console.ReadLine();
//if(userInput == "Print person")
//{
//    Person person1 = new Person() { Name = "Iggy", Age = 27};
//    Console.WriteLine(person1.Name + " is " + person1.Age + " years old.");
//}



bool someCondition = true;
if (someCondition)
{
    var someClassInstance = new SomeClass(); // uvijek ce biti reachable to _allExistingInstances - prouzrokuje memory leaks
}


Console.WriteLine("Count of all instances is now " + SomeClass.CountOfInstances);

for (int i = 0; i < 5; ++i)
{
    var personIggy = new Person { Name = "IggyPop", Age = 40 };
}

//GC.Collect(); //shouldn't be used in production, only for debugging
//Console.WriteLine("Ready to close.");

const string filePath = "file.txt";
var writer = new FileWriter(filePath);
writer.Write("Some text");
writer.Write("Some other text");

var reader = new SpecificLineFromTextFileReader(filePath);
var third = reader.ReadLineNumber(3);
var fourth = reader.ReadLineNumber(4);

Console.WriteLine("The third line is "  + third);
Console.WriteLine("The fourth line is "  + fourth);

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
