﻿
using Utilities;

var numbers = new int[] { 1, 2, 3, 4, 5 };
Console.WriteLine(numbers.AsString());


//InternalClass internalClass;
//

//new PublicClass().ProtectedInternal(); - ne moze zato sto je protected

Console.WriteLine("Press any key to close app.");
Console.ReadKey();

public class DerivedFromPublicClass : PublicClass
{
    public void Test()
    {
        ProtectedInternal();
    }
}