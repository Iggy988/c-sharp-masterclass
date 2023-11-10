
SomeMethod method1 = Test1;
//SomeMethod method2 = Test2;

method1 += Test3; //dodavanje metoda
method1 -= Test3; //uklanjane metoda iz delegata

method1(10, 2);

const int Treshold = 30_000;

var emailPriceChangeNotifierr = new EmailPriceChangeNotifier(Treshold);
var pushPriceChangeNotifier = new PushPriceChangeNotifier(Treshold);

var goldPriceReader = new GoldPriceReader();
goldPriceReader.PriceRead += emailPriceChangeNotifierr.Update;
goldPriceReader.PriceRead += pushPriceChangeNotifier.Update;
goldPriceReader.PriceReadDelegate += pushPriceChangeNotifier.Update;

//only class that holds event can raise it
//goldPriceReader.PriceRead(null, null); // we cannot invoke event otside class it belongs to
goldPriceReader.PriceReadDelegate(null, null); //we can invoke delegeta

for (int i = 0; i < 3; ++i)
{
    goldPriceReader.ReadCurrentPrice();
}

Console.ReadKey();




void Test1(int num1, int num2) { }
void Test2(int a, int b, int c) { }
void Test3(int num1, int num2) { }

public delegate void SomeMethod(int a, int b);

//public delegate void PriceRead(decimal price); custom delegate

