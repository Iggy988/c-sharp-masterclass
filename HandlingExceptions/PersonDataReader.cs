using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandlingExceptions;

public class PersonDataReader
{
    private readonly IPeopleRepository _peopleRepository;
    private readonly ILogger _logger;

    public PersonDataReader(
        IPeopleRepository personRepository,
        ILogger logger)
    {
        _peopleRepository = personRepository;
        _logger = logger;
    }

    public Person ReadPersonData(int personId)
    {
        try
        {
            return _peopleRepository.Read(personId);
        }
        catch (Exception ex)
        {
            _logger.Log(ex);
            throw;
        }
    }
}

public interface IPeopleRepository
{
    Person Read(int personId);
}

public interface ILogger
{
    void Log(Exception ex);
}
