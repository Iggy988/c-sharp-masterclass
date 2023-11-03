﻿
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

Console.ReadKey();


void Modify(string input)
{
    input += "xyz";
}

public struct TestStruct
{
    public string Text { get; set; }
}