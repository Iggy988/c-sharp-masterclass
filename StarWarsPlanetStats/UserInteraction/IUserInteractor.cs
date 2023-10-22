public interface IUserInteractor
{
    void ShowMessage(string message);
    string? ReadFromUser();
    void PrintTable<T>(IEnumerable<T> items);
}
