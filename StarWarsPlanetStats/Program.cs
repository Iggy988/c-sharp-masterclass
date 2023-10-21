
using StarWarsPlanetStats.DTO;
using System.Text.Json;

IApiDataReader apiDataReader = new ApiDataReader();
var json = await apiDataReader.Read("https://swapi.dev/", "api/planets");

var root = JsonSerializer.Deserialize<Result>(json);

Console.WriteLine("Press any key to close");
Console.ReadKey();
