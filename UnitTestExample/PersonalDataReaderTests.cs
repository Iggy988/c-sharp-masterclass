using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities;
[TestFixture]
public class PersonalDataReaderTests
{

    [Test]
    public void test1()
    {
        var personalDataReader = new PersonalDataReader(new DatabaseConnection());

        string result = personalDataReader.Read(5);

        Assert.AreEqual("(Id: 5) John Smith", result);
    }
}

















//databaseConnectionMock
//    .SetupSequence(mock => mock.GetById(It.Is<int>(id => id > 0)))
//            .Returns(new Person(1, "Anna", "Smith"))
//            .Returns(new Person(2, "Jake", "Smith"))
//            .Returns(new Person(3, "Bill", "Smith"));

//        databaseConnectionMock
//           .Setup(mock => mock.GetById(It.IsAny<int>()))
//           .Throws(new Exception("Some message"));



//databaseConnectionMock.Verify(
//    mock => mock.Write(personToBeSaved.Id, personToBeSaved),
//            Times.Once());

//        databaseConnectionMock.Verify(
//            mock => mock.Write(It.IsAny<int>(), personToBeSaved),
//            Times.Never());