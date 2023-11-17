namespace Utilities;

public interface IDatabaseConnection
{
    Person GetById(int id);
    void Write(int id, Person person);
}