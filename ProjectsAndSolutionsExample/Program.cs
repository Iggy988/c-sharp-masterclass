using Newtonsoft.Json;
using Utilities;

var json = JsonConvert.SerializeObject(5);

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
        ProtectedInternal(); // moze se unutar derived class pozivati
        //PrivateProtected();  ne moze zato sto je u razlicitom assemblyju
    }
}