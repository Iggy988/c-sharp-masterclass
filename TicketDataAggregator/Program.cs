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
        using (PdfDocument document = PdfDocument.Open(_ticketFolder + @"\Tickets1.pdf"))
        {

            Page page = document.GetPage(1);
            string text = page.Text;
        }
    }
}

