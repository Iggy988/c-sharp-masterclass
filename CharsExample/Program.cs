

using System.Text;

char letter = 'a';
char digit = '3';
char symbol = '!';
char newLine = '\n';

var isUppercase = char.IsUpper(letter); //will be false
var isLetter = char.IsLetter(digit); //will be false
var isDigit = char.IsDigit(letter); //will be false
var isWhitespace = char.IsWhiteSpace(newLine); //will be true
var aToUpper = char.ToUpper(letter); //will give 'A'


char someChar = (char)100;
int asInt = (int)'t';

//for (char c = 'A'; c < 'z'; ++c)
//{
//    Console.Write(c + ", ");
//}

var currentEncoding = Console.OutputEncoding;
Console.OutputEncoding = Encoding.Unicode;

char omega = 'Ω';
Console.WriteLine(omega);
Console.WriteLine((int)omega);

char dal = 'د';
Console.WriteLine(dal);
Console.WriteLine((int)dal);

Console.ReadKey();