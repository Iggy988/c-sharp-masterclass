using Moq;
using NUnit.Framework;

namespace Utilities;
[TestFixture]
public class PersonalDataReaderTests
{
    private PersonalDataReader _cut;
    private Mock<IDatabaseConnection> _databaseConnectionMock;

    [SetUp]
    public void Setup()
    {
        _databaseConnectionMock = new Mock<IDatabaseConnection>();
        _cut = new PersonalDataReader(_databaseConnectionMock.Object);
    }

    [Test]
    public void Read_ShallProduceResultWithDataOfPersonReadFromTheDatabase()
    {


        _databaseConnectionMock
            //.SetupSequence(mock => mock.GetById(It.Is<int>(id => id > 0)))
            //.Returns(new Person(1, "Ana", "Smith"))
            //.Returns(new Person(2, "Jake", "Smith"))
            //.Returns(new Person(3, "Bill", "Smith"));
            .Setup(mock => mock.GetById(It.IsAny<int>()))
            //.Throws(new Exception("Some message"));
            .Returns(new Person(5, "John", "Smith"));


        string result = _cut.Read(5);
        //databaseConnectionMock.Reset();
        //string result2 = personalDataReader.Read(5);

        Assert.AreEqual("(Id: 5) John Smith", result);
    }

    [Test]
    public void Save_ShallCallTheWriteMethod_WithCorrectArguments()
    {


        var personToBeSaved = new Person(10, "Jane", "Miller");
        _cut.Save(personToBeSaved);

        //databaseConnectionMock.Verify(mock => mock.Write(personToBeSaved.Id, personToBeSaved), Times.Once());

        //databaseConnectionMock.Verify(mock => mock.Write(It.Is<int>(id => id > 0), It.IsAny<Person>()));

        _databaseConnectionMock.Verify(mock => mock.Write(personToBeSaved.Id, personToBeSaved));
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