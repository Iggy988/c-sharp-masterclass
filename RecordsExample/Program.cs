
var weatherData = new WeatherData(25.1M, 65);
Console.WriteLine(weatherData);

var warmerWeatherData = weatherData with { Temperatue = 30 };

var rectangle = new Rectangle(12, 20);
//rectangle.A = 15; //mutable , if put readonly it will  be immutable

Console.ReadKey();

public record WeatherData(decimal Temperatue, int Humidity);

public readonly record struct Rectangle(int A, int B);

public record WeatherDataNonPositionalRecord
{
    public decimal Temperature { get; set; }
    public int Humidity { get; }
    public WeatherDataNonPositionalRecord(decimal temperature, int humidity)
    {
        Temperature = temperature;
        Humidity = humidity;
    }
}

public class WeatherDataClass : IEquatable<WeatherDataClass?>
{
    //immutable - no setters
    public decimal Temperature { get; }
    public int Humidity { get; }

    public WeatherDataClass(decimal temperature, int humidity)
    {
        Temperature = temperature;
        Humidity = humidity;
    }

    public override string ToString()
    {
        return $"Temperature {Temperature} Humidity {Humidity}";
    }

    public override bool Equals(object? obj)
    {
        return Equals(obj as WeatherDataClass);
    }

    public bool Equals(WeatherDataClass? other)
    {
        return other is not null &&
               Temperature == other.Temperature &&
               Humidity == other.Humidity;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Temperature, Humidity);
    }

    public static bool operator ==(WeatherDataClass? left, WeatherDataClass? right)
    {
        return EqualityComparer<WeatherDataClass>.Default.Equals(left, right);
    }

    public static bool operator !=(WeatherDataClass? left, WeatherDataClass? right)
    {
        return !(left == right);
    }
}