
using StarWarsPlanetStats.DTO;
using System.Text.Json;

try
{
    await new StarWarsPlanetsStatsApp(
        new ApiDataReader(),
        new MockStarWarsApiDataReader()).Run();
}
catch (Exception ex)
{
    Console.WriteLine("An error occurred. Exception message: " + ex.Message);
}

Console.WriteLine("Press any key to close");
Console.ReadKey();


internal class StarWarsPlanetsStatsApp
{
    //Dependency inversion - classes should depend on abstraction
    private readonly IApiDataReader _apiDataReader;
    private readonly IApiDataReader _secondaryApiDataReader;

    public StarWarsPlanetsStatsApp(IApiDataReader apiDataReader, IApiDataReader secondaryApiDataReader)
    {
        _apiDataReader = apiDataReader;
        _secondaryApiDataReader = secondaryApiDataReader;
    }

    public async Task Run()
    {
        string? json = null;
        try
        {
            json = await _apiDataReader.Read("https://swapi.dev/", "api/planets");
        }
        catch (HttpRequestException ex)
        {
            Console.WriteLine("API request was unsuccessful. Switching to mock data. Exception message " + ex.Message);
        }

        // if json is null use mock class
        json ??= await _secondaryApiDataReader.Read("https://swapi.dev/", "api/planets");

        var root = JsonSerializer.Deserialize<Root>(json);

        var planets = ToPlanets(root);

        foreach (var planet in planets)
        {
            Console.WriteLine(planet);
        }

        var propertyNamesToSelectorsMapping = new Dictionary<string, Func<Planet, int?>>
        {
            ["population"] = p => p.Population,
            ["diameter"] = p => p.Diameter,
            ["surface water"] = p => p.SurfaceWater
        };

        Console.WriteLine();
        Console.WriteLine("The statistic of which property you like to see?");
        Console.WriteLine(string.Join(Environment.NewLine, propertyNamesToSelectorsMapping.Keys));

        var userChoice = Console.ReadLine();
        if (userChoice is null || !propertyNamesToSelectorsMapping.ContainsKey(userChoice))
        {
            Console.WriteLine("Invalid choice");
        }
        else
        {
            ShowStatistics(planets,userChoice, propertyNamesToSelectorsMapping[userChoice]);
        }
    }

    private static void ShowStatistics(
       IEnumerable<Planet> planets,
       string propertyName,
       Func<Planet, int?> propertySelector)
    {
        ShowStatisticsInfo(
            "Max",
            planets.MaxBy(propertySelector),
            propertySelector,
            propertyName);

        ShowStatisticsInfo(
            "Min",
            planets.MinBy(propertySelector),
            propertySelector,
            propertyName);
    }

    private static void ShowStatisticsInfo(string descriptor, Planet selectedPlanet, Func<Planet, int?> propertySelector, string propertyName)
    {
        Console.WriteLine($"{descriptor} {propertyName} is: " +
            $"{propertySelector(selectedPlanet)} " +
            $"(planet: {selectedPlanet.Name})");
    }

    private static IEnumerable<Planet> ToPlanets(Root? root)
    {
        if (root is null)
        {
            throw new ArgumentNullException(nameof(root));
        }
        
        return root.results.Select(planetDto => (Planet)planetDto);

        //var planets = new List<Planet>();

        //foreach (var planetDto in root.results)
        //{
        //    Planet planet = (Planet)planetDto;
        //    planets.Add(planet);
        //}

        //return planets;
    }
}


