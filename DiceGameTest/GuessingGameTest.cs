using Moq;

namespace DiceGameTest;

public class GuessingGameTest
{

    [Test]
    public void Play_ShallReturnVictory_IfTheUserGuessesTheNumberOnTheFirstTime()
    {
        var diceMock = new Mock<IDice>();
        const int NumberOnDie = 3;
        diceMock.Setup(mock => mock.Roll()).Returns(NumberOnDie);
        var cut = new GuessingGame(diceMock.Object);

        var gameResult = cut.Play();
    }
}