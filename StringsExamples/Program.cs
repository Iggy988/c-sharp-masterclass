
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

Console.ReadKey();


void Modify(string input)
{
    input += "xyz";
}