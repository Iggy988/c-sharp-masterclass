
using static System.Runtime.InteropServices.JavaScript.JSType;

var wordsNoUppercase = new string[]
{
    "quick", "brown", "fox"
};
Console.WriteLine(IsAnyWordUpperCase(wordsNoUppercase));
var wordsWithUppercase = new string[]
{
    "quick", "brown", "FOX"
};
Console.WriteLine(IsAnyWordUpperCase_Linq(wordsWithUppercase));

var words = new List<string> { "a", "bb", "ccc", "dddd" };
var wordsLongerThan2 = words.Where(word => word.Length > 2);
//Linq nije data vec query, ako pretvorimo linq u list nece uvrstiti e iako ga dodamo
var wordsShorterThan3 = words.Where(word => word.Length < 3).ToList();
words.Add("e");
foreach (var word in wordsShorterThan3)
{
    Console.WriteLine(word);
}

var numbers = new int[] { 7, 5, 3, 4, 2, 6, 1 };
//var oddNumbers = numbers.Where(number => number %2 == 1);
var orderOddNumbers = numbers.Where(number => number % 2 == 1).OrderByDescending(number => number);
Console.WriteLine("Ordered numbers: " + string.Join(", ", orderOddNumbers));

var NumbersWith10 = numbers.Append(10); //kreira se nova collection

//LINQ methods take IEnumerable<T> as a parameter
//LINQ methods return IEnumerable<T>
//Deferred execution means that the evaulation of a LINQ expreddion is delayed until the value is actually needed (avoids unnecessary execution)
//Any - used to check if any element satisfy the given criteria, returns bool

var people = new List<Person>
{
    new Person("Igor", "BiH"),
    new Person("Joldza", "USA"),
};

var allBosnians = people.Where(person => person.Countury == "BiH");
Console.WriteLine(string.Join(" ", allBosnians));

var notAllBosnians = allBosnians.Take(100);

var animals = new List<string>()
{
    "Duck", "Lion", "Dolphin", "Cat"
};

var animalsWithD = animals.Where(animal =>
{
    //Console.Write("Checking animal: " + animal);
    return animal.StartsWith("D");
});

Console.WriteLine(string.Join(Environment.NewLine, animalsWithD));

//foreach (var animal in animalsWithD)
//{
//    Console.WriteLine(animal);
//}

Console.ReadKey();

static bool IsAnyWordUpperCase_Linq(IEnumerable<string> words)
{ 
    return words.Any(word => word.All(letter =>char.IsUpper(letter)));
}

    static bool IsAnyWordUpperCase(IEnumerable<string> words)
{
    foreach (var word in words)
    {
        bool areUpperCase = true;  
        foreach (var letter in word) 
        {
            if (char.IsLower(letter))
            {
                areUpperCase = false;
            }
        }
        if (areUpperCase)
        {
            return true;
        }
    }
    return false;
}




