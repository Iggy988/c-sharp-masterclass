public class SomeClass
{
    private static List<SomeClass> _allExistingInstances = new();

    public static int CountOfInstances => _allExistingInstances.Count;

    public SomeClass()
    {
        _allExistingInstances.Add(this);
    }
}