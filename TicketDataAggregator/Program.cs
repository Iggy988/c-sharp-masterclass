using TicketDataAggregator.TicketsAggregator;

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

Console.WriteLine("Press any key to close.");

Console.ReadKey();

