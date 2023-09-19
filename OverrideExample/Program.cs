
var numbers = new List<int> { 1, 4, 6, -1, 12, 44, -8, -19 };

bool shallAddPositiveOnly = false;

NumbersSumCalculator calculator =

shallAddPositiveOnly ?

new PositiveNumbersSumCalculator() :

new NumbersSumCalculator();

int sum = calculator.Calculate(numbers);

Console.WriteLine("Sum is: " + sum);

Console.ReadKey();
