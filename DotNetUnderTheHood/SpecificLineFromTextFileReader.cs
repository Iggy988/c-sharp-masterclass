public class SpecificLineFromTextFileReader : IDisposable
{
    private readonly StreamReader _streamReader;
    public SpecificLineFromTextFileReader(string filePath)
    {
        _streamReader = new StreamReader(filePath);
    }

    
    public string ReadLineNumber(int lineNumber)
    {
        _streamReader.DiscardBufferedData(); //empties buffer of streamReader
        _streamReader.BaseStream.Seek(0, SeekOrigin.Begin); //moves reader at the beginig of file
        //npr ako je lineNumber 5 - for loop ce iterate 4 puta i onda ce method return return 5. line
        for (int i = 0; i < lineNumber - 1; ++i)
        {
            _streamReader.ReadLine();
        }
        return _streamReader.ReadLine();
    }

    public void Dispose()
    {
        _streamReader.Dispose();
    }

}
