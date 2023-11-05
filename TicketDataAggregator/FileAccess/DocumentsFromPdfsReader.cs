using UglyToad.PdfPig.Content;
using UglyToad.PdfPig;

namespace TicketDataAggregator.FileAccess;

public class DocumentsFromPdfsReader : IDocumentReader
{
    public IEnumerable<string> Read(string directory)
    {
        //GetFiles(folder where to search, pattern what to search)
        foreach (var filePath in Directory.GetFiles(directory, "*.pdf"))
        {
            using PdfDocument document = PdfDocument.Open(filePath);

            Page page = document.GetPage(1);
            yield return page.Text;
        }
    }
}
