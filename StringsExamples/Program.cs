
string text = "abc";
text += "d";

var upperCase = text.ToUpper();
Console.WriteLine(text);
Console.WriteLine(upperCase);

string text1 = "abc";
string text2 = "abc";
Console.WriteLine(text1.Equals(text2));

Modify(text1);

Console.WriteLine(text1);

var test = new TestStruct
{
    Text = "abc"
};

var other = test;

const int Count = 100;

var text3 = string.Empty;
for (int i = 0; i < Count; i++)
{
    text3 += "a";
}


Console.ReadKey();


void Modify(string input)
{
    input += "xyz";
}

public struct TestStruct
{
    public string Text { get; set; }
}