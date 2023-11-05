namespace TicketDataAggregator.Extensions;

public static class WebAddressExtension
{
    //domain is part that starts at last dot (www.ourSite.com)
    public static string ExtractDomain(this string webAddress)
    {
        var lastDotIndex = webAddress.LastIndexOf('.');
        return webAddress.Substring(lastDotIndex);
    }
}