//readonly collection
//Hash Set
public class SpellCheck
{
    private readonly HashSet<string> _correctWords = new()
    {
        "cat", "dog", "fish"
    };
    public bool IsCorrect(string word) => _correctWords.Contains(word);

    public void addCorrectWord(string word) => _correctWords.Add(word);
}
