using UglyToad.PdfPig.Content;
using UglyToad.PdfPig;

const string TicketFolder = @"D:\C#&.NET projects\C#Masteclass\TicketDataAggregator\Tickets";

try
{
	var ticketsAggregator = new TicketsAggregator(TicketFolder);

	ticketsAggregator.Run();
}
catch (Exception ex)
{
    Console.WriteLine("An exception occured. Exception message: " + ex.Message );
}

Console.ReadKey();

public class TicketsAggregator
{
    private string _ticketFolder;

    public TicketsAggregator(string ticketFolder)
    {
        _ticketFolder = ticketFolder;
    }

    public void Run()
    {

        //GetFiles(folder where to search, pattern what to search)
        foreach (var filePath in Directory.GetFiles(_ticketFolder, "*.pdf"))
        {
            using PdfDocument document = PdfDocument.Open(filePath);

            Page page = document.GetPage(1);
            string text = page.Text;
            var split = text.Split(new[] { "Title:", "Date:", "Time:", "Visit us:"}, StringSplitOptions.None);

            //-3 zato sto ignorisemo visit us
            for (int i = 1; i < split.Length -3; i += 3)
            {
                var title = split[i];
                var date = split[i + 1];
                var time = split[i + 2];
            }
        }
    }
}

