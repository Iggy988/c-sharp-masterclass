

var evenNumber = GenerateEvenNumbers();

var firstThreEvenNumbers = evenNumber.Take(3).ToList();
foreach (var number in firstThreEvenNumbers.Take(3))
{
	Console.WriteLine($"Number is {number}");
}

foreach (var number in firstThreEvenNumbers.Take(3))
{
    Console.WriteLine($"Number is {number}");
}


var smallSubset = GenerateEvenNumbers().Skip(4).Take(10);

//foreach (var number in GenerateEvenNumbers())
//{
//	if (number == 50)
//	{
//		break;
//	}
//	Console.WriteLine(number);
//}	

var firstEvenNumber = GenerateEvenNumbers().First();


foreach (var number in GetSingleDigitNumbers())
{
	Console.WriteLine(number);
}

var input = new[] { "a", "b", "c", "d", "b", "a"};

foreach (var item in Distinct(input))
{
    Console.WriteLine(item);
}

var numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, -2, 1, 3 };
foreach (var item in GetBeforeFirstNegative(numbers))
{
	Console.WriteLine(item);
}

var customCollection = new CustomCollectionWithIteretors(new string[] { "aaa", "bbb", "ccc" });
foreach (var w in customCollection)
{
    Console.WriteLine(w);
}

Console.ReadKey();


IEnumerable<int> GetBeforeFirstNegative(IEnumerable<int> input)
{
	foreach (var number in input)
	{
		if (number >= 0)
		{
			yield return number;
		}
		//moramo staviti brake u else statement ili ce brake oiperation nakon prve iteracije
		else
		{
            yield break;
        }
		
	}
}


IEnumerable<T> Distinct<T>(IEnumerable<T> input)
{
	var hashSet = new HashSet<T>();
	foreach (var item in input)
	{
		//hashSet - collection of unique values
		//ako iterated item nije contained u hashSetu, znaci da se prvi put susrece sa njim
		if (!hashSet.Contains(item))
		{
			//dodajemo item u hashSet
			hashSet.Add(item);
			//yield-amo item
			yield return item;
            Console.WriteLine("After Yield");
        }
	}
}	

IEnumerable<int> GetSingleDigitNumbers()
{
	yield return 0;
	yield return 1;
	yield return 2;
	yield return 3;
	yield return 4;
	yield return 5;
	yield return 6;
	yield return 7;
	yield return 8;
	yield return 9;
}


IEnumerable<int> GenerateEvenNumbers()
{
    //var result = new List<int>();
	for (int i = 0; i < int.MaxValue; i += 2)
	{
		//result.Add(i);
		Console.WriteLine($"Yielding {i}");
		yield return i;
	}
	//return result;
}