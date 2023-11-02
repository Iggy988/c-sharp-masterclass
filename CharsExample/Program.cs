

char letter = 'a';
char digit = '3';
char symbol = '!';
char newLine = '\n';

var isUppercase = char.IsUpper(letter); //will be false
var isLetter = char.IsLetter(digit); //will be false
var isDigit = char.IsDigit(letter); //will be false
var isWhitespace = char.IsWhiteSpace(newLine); //will be true
var aToUpper = char.ToUpper(letter); //will give 'A'

Console.ReadKey();