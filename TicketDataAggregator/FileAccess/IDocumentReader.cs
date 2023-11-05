namespace TicketDataAggregator.FileAccess;

public interface IDocumentReader
{
    IEnumerable<string> Read(string directory);
}
