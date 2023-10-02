using System.Numerics;

public static class Calculator
{
    public static T Square<T> (T input) where T: INumber<T> => input * input;
    // nekad je moralo da se pravi vise metoda koja obradjuje svaki type posebno
    //public static int Square(int input) => input * input;
    //public static decimal Square(decimal input) => input * input;
    //public static double Square(double input) => input * input;

}
