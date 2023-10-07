
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

var numbers = new int[] {10, 7, 5, 3, 4, -5, 2, 6, 1, -13 };

var firstNumber = numbers.First();
Printer.Print(firstNumber, nameof(firstNumber));

var firstOddNumber = numbers.First(number => number % 2 ==1);
Printer.Print(firstOddNumber, nameof(firstOddNumber));

var orderNumbers = numbers.OrderBy(x => x);
Printer.Print(orderNumbers, nameof(orderNumbers));

//Count - checks is given element present in collection
var is7Present = numbers.Contains(7);
Printer.Print(is7Present, nameof(is7Present));

var areAllLargerThanZero = numbers.All(x => x > 0);
Printer.Print(areAllLargerThanZero, nameof(areAllLargerThanZero));

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

var pets = new[]
            {
                new Pet(1, "Hannibal", PetType.Fish, 1.1f),
                new Pet(2, "Anthony", PetType.Cat, 2f),
                new Pet(3, "Ed", PetType.Cat, 0.7f),
                new Pet(4, "Taiga", PetType.Dog, 35f),
                new Pet(5, "Rex", PetType.Dog, 40f),
                new Pet(6, "Lucky", PetType.Dog, 5f),
                new Pet(7, "Storm", PetType.Cat, 0.9f),
                new Pet(8, "Nyan", PetType.Cat, 2.2f)
            };

var lastDog = pets.Last(p => p.PetType == PetType.Dog);
Printer.Print(lastDog, nameof(lastDog));

//ako koristimo First or Last moramo biti sigurni da ce biti element u skladu sa postavljenim queryjem jer u suprotnom ce vratiti exception
//var lastHavierThan100 = pets.Last(p => p.Weight > 100);
//Printer.Print(lastHavierThan100, nameof(lastHavierThan100));

var lastHavierThan100 = pets.LastOrDefault(p => p.Weight > 100);
Printer.Print(lastHavierThan100, nameof(lastHavierThan100));

var heaviestPet = pets.OrderBy(p=>p.Weight).Last();
Printer.Print(heaviestPet, nameof(heaviestPet));

var petsOrderByTypeThenName = pets.OrderBy(p => p.PetType).ThenBy(p =>p.Name);
Printer.Print(petsOrderByTypeThenName, nameof(petsOrderByTypeThenName));

var petsOrderByName = pets.OrderBy(p => p.Name);
Printer.Print(petsOrderByName, nameof(petsOrderByName));

var petsOrderByIdDesc = pets.OrderByDescending(p => p.Id);
Printer.Print(petsOrderByIdDesc, nameof(petsOrderByIdDesc));

var countOfDogs = pets.Count(pet => pet.PetType == PetType.Dog);
Printer.Print(countOfDogs, nameof(countOfDogs));

var countOfSmallDogs = pets.Count(pet => pet.PetType == PetType.Dog && pet.Weight < 10);
Printer.Print(countOfSmallDogs, nameof(countOfSmallDogs));

var allPets = pets.Count();
Printer.Print(allPets, nameof(allPets));

var countOfPetsNamedBruce = pets.LongCount(pet => pet.Name == "Bruce");
Printer.Print(countOfPetsNamedBruce, nameof(countOfPetsNamedBruce));

var doAllHaveNoEmptyNames = pets.All(pet => !string.IsNullOrEmpty(pet.Name));
Printer.Print(doAllHaveNoEmptyNames, nameof(doAllHaveNoEmptyNames));

var areAllCats = pets.All(pet => pet.PetType == PetType.Cat);
Printer.Print(areAllCats, nameof(areAllCats));

var isAnyPetNamedBruce = pets.Any(pet => pet.Name == "Bruce");
Printer.Print(isAnyPetNamedBruce, nameof(isAnyPetNamedBruce));

var isAnyFish = pets.Any(pet => pet.PetType == PetType.Fish);
Printer.Print(isAnyFish, nameof(isAnyFish));

var isThereAVerySpecifcPet= pets.Any(pet => pet.Name.Length > 6 && pet.Id % 2 == 0);
Printer.Print(isThereAVerySpecifcPet, nameof(isThereAVerySpecifcPet));

var isNotEmpty = pets.Any();

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

