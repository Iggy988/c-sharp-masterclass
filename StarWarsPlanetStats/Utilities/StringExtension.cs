public static class StringExtension
{
    //extension method
    public static int? ToIntOrNull(this string? input)
    {
        return int.TryParse(input, out int resultParsed) ? resultParsed : null;
    }
}


