
namespace StarWarsPlanetStats.DataAccess;
public interface IPlanetsReader
{
    Task<IEnumerable<Planet>> Read();
}
