//Equals method and == operator
var john = new Person(1, "John");
var theSameAsJohn = new Person(1, "John");
var marie = new Person(2, "Marie");
//Console.WriteLine(object.ReferenceEquals(1,1));   
//Console.WriteLine(object.ReferenceEquals(null,null));   
Console.WriteLine("Are reference equals? " + object.ReferenceEquals(john, theSameAsJohn));

Console.WriteLine("1.Equals(1): " + 1.Equals(1));
Console.WriteLine("1.Equals(2): " + 1.Equals(2));
Console.WriteLine("1.Equals(null): " + 1.Equals(null));
Console.WriteLine(
    "\"abc\".Equals(\"abc\"): " + "abc".Equals("abc"));
Console.WriteLine();

Console.WriteLine(
    "john.Equals(theSameAsJohn): " + john.Equals(theSameAsJohn));

Console.WriteLine("john.Equals(marie): " + john.Equals(marie));
Console.WriteLine("john.Equals(null): " + john.Equals(null));


var point1 = new Point(1, 2);
var point2 = new Point(1, 2);
Console.WriteLine("point1.Equals(point2): "+point1.Equals(point2)); //value types


Console.WriteLine("point1 == point2 " + (point1 == point2)); 
Console.WriteLine("point1 != point2 " + (point1 != point2)); 
Console.WriteLine("1 == 1" + (1 == 1));

var added = point1 + point2;

var addedd = point1.Add(point2);

int tenAsInt = 10;
//conversion operator is overrloaded
//implicit conversion, dasnt require any sintax, it is safe
decimal tenAsDecimal = tenAsInt;

decimal someDecimal = 20.01M;
//Explisit conversion, we know or risk of losing some data
int someInt = (int)someDecimal;

var tuple = Tuple.Create(10, 20);
//Point point = (Point)tuple; // moramo ubaciti nas implicit conversion
Point point = tuple; // moramo ubaciti nas implicit conversion


var hash1 = 324.GetHashCode();
var hash2 = "abc".GetHashCode();
Console.WriteLine(hash1);
Console.WriteLine(hash2);

var dictionary = new Dictionary<Point, string>();
dictionary[new Point(10, 20)] = "abc";

Console.ReadKey();
