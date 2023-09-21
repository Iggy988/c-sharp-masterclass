using ExtensionMethodsExample.Extensions;

var multilineText = @"aaa
	sss
	ccc
	asadd";

//Console.WriteLine("Count of lines is " + CountLines(multilineText));

Console.WriteLine("Count of lines is " + multilineText.CountLines());
Console.WriteLine("Count of lines is " + StringExtensions.CountLines(multilineText));

Console.WriteLine("Next after spring is " + Season.Spring.Next());
Console.WriteLine("Next after winter is " + Season.Winter.Next());

//int CountLines(string input) => input.Split(Environment.NewLine).Length;

Console.ReadKey();