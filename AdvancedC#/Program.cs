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

var dictionary2 = new Dictionary<Person, int>();
var martin = new Person(6, "Martin");
dictionary2[martin] = 5;
var theSameAsMarthin = new Person(6, "Martin");
Console.WriteLine(martin.GetHashCode());
Console.WriteLine(theSameAsMarthin.GetHashCode());
//Console.WriteLine(dictionary2[theSameAsMarthin]);


var dictionary3 = new Dictionary<Point, int>();
var point3 = new Point(10, 20);
dictionary3[point3] = 99;
var point4 = new Point(10, 20);
Console.WriteLine(dictionary3[point3]);
Console.WriteLine(point3.GetHashCode());
Console.WriteLine(point4.GetHashCode());


var tuple1 = new Tuple<string, bool>("aaa", false);
var tuple2 = Tuple.Create(10, true);
var tuple3 = Tuple.Create(10, true);
var number = tuple2.Item1;
//tuple2.Item1 = 23; // ne moze zato sto je setter read only
Console.WriteLine(tuple2 == tuple3);
Console.WriteLine(tuple2 == tuple3);
Console.WriteLine(tuple2.Equals(tuple3));
Console.WriteLine(tuple3.GetHashCode());


var valueTuple1 = new ValueTuple<int, string>(1, "bbb");
var valueTuple2 = (Number: 5, Text: "ccc");
valueTuple2.Item1 = 30;// ValueTuples are mutable
valueTuple2.Text = "ddd";


//Nullable value types
//int numberNull = null;
string text = null;

int? numberOrNull = null;
Nullable<bool> boolOrNull = true;
//Nullable<string> stringOrNull = null; // ne moze reference type

//int numbers2 = numberOrNull.Value; //nullable ints and int are not the same value, we must unpack it
if (numberOrNull.HasValue)
{
    Console.WriteLine("not null");
}

if (boolOrNull is not null)
{
    var someBool = boolOrNull.Value;
    Console.WriteLine(someBool);
}

var heights = new List<Nullable<int>>
{
    160, null, 190, null, 170
};

var averageHeight = heights
    .Where(h => h is not null)
    .Average();

Console.WriteLine("Average height is "+ averageHeight);

Console.ReadKey();
