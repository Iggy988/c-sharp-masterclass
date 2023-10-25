
//readonly collection
using System.Collections.ObjectModel;

var planets = ReadPlanets();
//var asList = (List<string>)planets;
var asList = (ReadOnlyCollection<string>)planets;
//planets.Clear();
//asList.Clear();
//asList[0] = "abc";

var dictionary = new Dictionary<string, int>
{
    ["aaa"] = 1
};

var readonlyDic = new ReadOnlyDictionary<string, int>(dictionary);
//readonlyDic.Clear();
//readonlyDic["bbb"] = 5;

Console.ReadKey();


//Big O Notation
bool Contains<T>(T itemToCheck, IEnumerable<T> input)
{
    foreach (var item in input)
    {
        if (item.Equals(itemToCheck))
        {
            return true;
        }
    }
    return false;
}

IEnumerable<string> ReadPlanets()
{
    var result = new List<string>
    {
        "Mars",
        "Earth",
        "Pluto"
    };    
    return new ReadOnlyCollection<string>(result) ;  
}
