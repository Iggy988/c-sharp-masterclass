public class FileWriter : IDisposable
{

    private readonly StreamWriter _streamWriter;
    public FileWriter(string filePath)
    {
        _streamWriter = new StreamWriter(filePath, true); // append da li ce dodavati tekst ili ce override u file.txt
    }

    public void Write(string text)
    {
        _streamWriter.WriteLine(text);
        // FLush - Clears all buffers for the current writer and causes any buffered data to be written to the underlying stream.
        // moramo koristiti da bi program ispisao tekst u file.txt
        _streamWriter.Flush();
    }

    public void Dispose()
    {
        _streamWriter.Dispose();
    }

    // ako zaboravimo pozvati Dispoze method, bice pozvan u finalizeru
    //~FileWriter() 
    //{
    //    Dispose();
    //}
}