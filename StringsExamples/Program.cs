
using System.Diagnostics;
using System.Text;

string text = "abc";
text += "d";

var upperCase = text.ToUpper();
Console.WriteLine(text);
Console.WriteLine(upperCase);

string text1 = "abc";
string text2 = "abc";
Console.WriteLine(text1.Equals(text2));
//string interning 
Console.WriteLine(object.ReferenceEquals(text1, text2));

Modify(text1);

Console.WriteLine(text1);

var test = new TestStruct
{
    Text = "abc"
};

var other = test;

const int Count = 200_000;

var text3 = string.Empty;
Stopwatch stopwatch = Stopwatch.StartNew();
for (int i = 0; i < Count; i++)
{
    text3 += "a"; // a aa aaa aaaa...
}

stopwatch.Stop();
Console.WriteLine($"Concatenation took {stopwatch.ElapsedMilliseconds} ms");

stopwatch.Restart();
var stringBuilder = new StringBuilder();
stopwatch.Start();
for (int i = 0; i < Count; i++)
{
    stringBuilder.Append("a");
}

var text4 = stringBuilder.ToString();

stopwatch.Stop();
Console.WriteLine($"Concatenation took {stopwatch.ElapsedMilliseconds} ms");

TestStringsMmoryConsumption(Count);

var text5 = string.Format("Number is {0}, number 2 is {1}", 100, 200);
Console.WriteLine(text5);

var someDecimal = 1.34M;
string.Format("Number is {0:C3}", someDecimal); //$1.34
string.Format("Number is {0:F1}", someDecimal); // 1.4
string.Format("Number is {0:P}", someDecimal);  //134.00%

DateTime someDate = new DateTime(2024, 5, 6, 12, 54, 12);
string.Format("Date is {0:d}", someDate); //5/6/2024
string.Format("Date is {0:D}", someDate); //Monday, May, 6, 2024
string.Format("Date is {0:MM/yyyy}", someDate); //05/24

Console.ReadKey();


void TestStringsMmoryConsumption(int count)
{
    var list = new List<string>(count);
    GC.Collect(2, GCCollectionMode.Default, true);
    var memoryBefore = GC.GetTotalMemory(false);

    for (int i = 0; i < Count; i++)
    {
        list.Add($"aaaaa{i}");
    }
    GC.Collect(2, GCCollectionMode.Default, true);
    var memoryAfter = GC.GetTotalMemory(false);
    Console.WriteLine("difference in bytes is " + (memoryAfter - memoryBefore));

}

void Modify(string input)
{
    input += "xyz";
}

public struct TestStruct
{
    public string Text { get; set; }
}