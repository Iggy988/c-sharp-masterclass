
class GuessingGame
{
    private readonly IDice _dice;
    private const int InitialTries = 3;

    public GuessingGame(IDice dice)
    {
        _dice = dice;
    }

    public GameResult Play()
    {
        var diceRollResult = _dice.Roll();
        Console.WriteLine($"Dice rolled. Guess what number it shos in {InitialTries} tries.");

        var triesLeft = InitialTries;
        while (triesLeft > 0)
        {
            var guess = ConsoleReader.ReadInteger("Enter a number:");

            if (guess == diceRollResult)

            {



                return GameResult.Victory;

            }

            --triesLeft;

        }

        // user je izgubio - nije pogodio broj u zadatom broju pokusaja

        return GameResult.Loss;

    }



    public static void PrintResult(GameResult gameResult)

    {

        string message = gameResult == GameResult.Victory ? "You win!" : "You lose :(";

        Console.WriteLine(message);

    }

}
