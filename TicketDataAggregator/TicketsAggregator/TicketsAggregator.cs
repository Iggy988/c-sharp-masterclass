using System.Globalization;
using System.Text;
using System.IO;
using TicketDataAggregator.Extensions;
using TicketDataAggregator.FileAccess;

namespace TicketDataAggregator.TicketsAggregator;

public class TicketsAggregator
{
    private string _ticketFolder;
    private readonly Dictionary<string, CultureInfo> _domainToCulture = new()
    {
        [".com"] = new CultureInfo("en-US"),
        [".fr"] = new CultureInfo("fr-FR"),
        [".jp"] = new CultureInfo("ja-JP")
    };

    private readonly IFileWriter _fileWriter;
    private readonly IDocumentReader _documentsReader;

    public TicketsAggregator(string ticketFolder, IFileWriter fileWriter, IDocumentReader documentsReader)
    {
        _ticketFolder = ticketFolder;
        _fileWriter = fileWriter;
        _documentsReader = documentsReader;
    }

    public void Run()
    {
        var stringBuilder = new StringBuilder();

        var ticketDocuments = _documentsReader.Read(_ticketFolder);

        foreach (var document in ticketDocuments)
        {
            var lines = ProcessDocument(document);
            stringBuilder.AppendLine(string.Join(Environment.NewLine, lines));
        }


        _fileWriter.Write(stringBuilder.ToString(), _ticketFolder, "aggregatedTickets.txt");
    }


    private IEnumerable<string> ProcessDocument(string document)
    {
        var split = document.Split(new[] { "Title:", "Date:", "Time:", "Visit us:" }, StringSplitOptions.None);

        var domain = split.Last().ExtractDomain();
        var ticketCulture = _domainToCulture[domain];

        //-3 zato sto ignorisemo visit us
        for (int i = 1; i < split.Length - 3; i += 3)
        {
            yield return BuildTicketData(split, i, ticketCulture);
        }
    }

    private static string BuildTicketData(string[] split, int i, CultureInfo ticketCulture)
    {
        var title = split[i];
        var dateAsString = split[i + 1];
        var timeAsString = split[i + 2];

        var date = DateOnly.Parse(dateAsString, ticketCulture);
        var time = TimeOnly.Parse(timeAsString, ticketCulture);

        var dateAsStringInvariant = date.ToString(CultureInfo.InvariantCulture);
        var timeAsStringInvariant = time.ToString(CultureInfo.InvariantCulture);

        var ticketData = $"{title,-40}|{dateAsStringInvariant}|{timeAsStringInvariant}";

        return ticketData;
    }

}
