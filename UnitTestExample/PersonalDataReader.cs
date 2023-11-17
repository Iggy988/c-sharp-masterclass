using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities;
public class PersonalDataReader
{
    private readonly IDatabaseConnection _databaseConnection;

    public PersonalDataReader(IDatabaseConnection databaseConnection)
    {
        _databaseConnection = databaseConnection;
    }

    public string Read(int id)
    {
        Person person = _databaseConnection.GetById(id);
        return $"(Id: {person.Id}) {person.FirstName} {person.LastName}";

    }

    public void Save(Person person)
    {
        _databaseConnection.Write(person.Id, person);
    }
}


