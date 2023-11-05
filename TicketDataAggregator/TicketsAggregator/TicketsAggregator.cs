using UglyToad.PdfPig.Content;
using UglyToad.PdfPig;
using System.Globalization;
using System.Text;

namespace TicketDataAggregator.TicketsAggregator
{
    public class TicketsAggregator
    {
        private string _ticketFolder;
        private readonly Dictionary<string, CultureInfo> _domainToCulture = new()
        {
            [".com"] = new CultureInfo("en-US"),
            [".fr"] = new CultureInfo("fr-FR"),
            [".jp"] = new CultureInfo("ja-JP")
        };

        public TicketsAggregator(string ticketFolder)
        {
            _ticketFolder = ticketFolder;
        }

        public void Run()
        {
            var stringBuilder = new StringBuilder();
            //GetFiles(folder where to search, pattern what to search)
            foreach (var filePath in Directory.GetFiles(_ticketFolder, "*.pdf"))
            {
                using PdfDocument document = PdfDocument.Open(filePath);

                Page page = document.GetPage(1);
                var lines = ProcessPage(page);
                stringBuilder.AppendLine(string.Join(Environment.NewLine, lines));
            }

            SaveTicketsData(stringBuilder);
        }


        private IEnumerable<string> ProcessPage(Page page)
        {
            string text = page.Text;
            var split = text.Split(new[] { "Title:", "Date:", "Time:", "Visit us:" }, StringSplitOptions.None);

            var domain = ExtractDomain(split.Last());
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

        private void SaveTicketsData(StringBuilder stringBuilder)
        {
            var resultPath = Path.Combine(_ticketFolder, "aggregatedTickets.txt");

            File.WriteAllText(resultPath, stringBuilder.ToString());
            Console.WriteLine("Results saved to " + resultPath);
        }

        //domain is part that starts at last dot (www.ourSite.com)
        private static string ExtractDomain(string webAddress)
        {
            var lastDotIndex = webAddress.LastIndexOf('.');
            return webAddress.Substring(lastDotIndex);
        }
    }
}