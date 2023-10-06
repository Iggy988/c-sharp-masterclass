
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

var numbers = new int[] { 1, 2, 3, 4, 5, 6 };
var oddNumbers = numbers.Where(number => number %2 == 1);


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




