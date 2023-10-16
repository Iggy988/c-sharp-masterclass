
//Point nullPoint = null; // structs are not nullable
Person nullPerson = null;

var point = new Point(1, 3);

MoveToRightBy1Unit(ref point); // nece isto raditi kao kod dole, osim ako ne ubacimo ref
//point.X++; //move to right by 1

var point2 = new Point(); // structs has always parameterless constructor
//Person person = new Person(); // moramo unijeti parametre

var anotherPoint = point with { X = point.X +1};
anotherPoint = point with { Y = 3};

Console.WriteLine(point);
Console.WriteLine(anotherPoint);

SomeMethod(5); //value type
//SomeMethod(new Person()); // ne moze reference type


var fishyStruct1 = new FishyStruct { Numbers = new List<int> { 1,2,3} };
var fishyStruct2 = fishyStruct1;

fishyStruct2.Numbers.Clear();

var dateTime = new DateTime(2023, 12, 3);
//nondestructive mutation
dateTime.AddDays(1);


//Console.WriteLine(object.ReferenceEquals(1,1));   
//Console.WriteLine(object.ReferenceEquals(null,null));   

var john = new Person(1, "John");
//var sameAsJohn = new Person(1, "John"); //false
var sameAsJohn = john;//true
Console.WriteLine("Are reference equals? " + object.ReferenceEquals(john, sameAsJohn));

Console.ReadKey();

void MoveToRightBy1Unit(ref Point point)
{
    //point.X++;
}

void SomeMethod<T>(T param) where T: struct
{

}
