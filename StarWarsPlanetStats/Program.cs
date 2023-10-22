try
{
    await new StarWarsPlanetsStatsApp(
        new PlanetsFromApiReader(new ApiDataReader(),
        new MockStarWarsApiDataReader()),
        new PlanetsStatisticsAnalyzer()
        ).Run();
}
catch (Exception ex)
{
    Console.WriteLine("An error occurred. Exception message: " + ex.Message);
}

Console.WriteLine("Press any key to close");
Console.ReadKey();
