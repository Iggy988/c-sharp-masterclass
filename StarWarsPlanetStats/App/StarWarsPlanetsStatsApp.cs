internal class StarWarsPlanetsStatsApp
{
    //Dependency inversion - classes should depend on abstraction
    private readonly IPlanetsReader _planetsReader;
    private readonly IPlanetsStatisticsAnalyzer _planetsStatisticsAnalyzer;

    public StarWarsPlanetsStatsApp(IPlanetsReader planetsReader, IPlanetsStatisticsAnalyzer planetsStatisticsAnalyzer)
    {
        _planetsReader = planetsReader;
        _planetsStatisticsAnalyzer = planetsStatisticsAnalyzer;
    }

    public async Task Run()
    {
        var planets = await _planetsReader.Read();

        foreach (var planet in planets)
        {
            Console.WriteLine(planet);
        }

        _planetsStatisticsAnalyzer.Analyze(planets);
    }

}
