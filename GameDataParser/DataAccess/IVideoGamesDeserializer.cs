public interface IVideoGamesDeserializer
{
    List<VideoGame> DeserializeFrom(string fileName, string fileContents);
}