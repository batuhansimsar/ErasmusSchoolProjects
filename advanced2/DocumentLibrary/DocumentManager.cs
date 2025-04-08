using DocumentLibrary.Models;
using DocumentLibrary.Exceptions;

namespace DocumentLibrary;

public class DocumentManager
{
    private List<Document> _documents;

    public DocumentManager()
    {
        _documents = new List<Document>();
    }

    public void AddDocument(Document document)
    {
        if (_documents.Any(d => d.ISBN == document.ISBN))
        {
            throw new DocumentAlreadyExistsException($"Document with ISBN {document.ISBN} already exists.");
        }

        if (document is Volume volume)
        {
            if (volume.VolumeNumber > volume.TotalVolumes)
            {
                throw new InvalidVolumeNumberException(
                    $"Volume number {volume.VolumeNumber} cannot be greater than total volumes {volume.TotalVolumes}.");
            }
        }

        if (document is Book book && book.PublicationYear < 1440)
        {
            throw new InvalidPublicationYearException(
                $"Publication year {book.PublicationYear} is before the invention of printing (1440).");
        }

        _documents.Add(document);
    }

    public Document? GetDocumentByISBN(string isbn)
    {
        return _documents.FirstOrDefault(d => d.ISBN == isbn);
    }

    public List<Document> SearchByTitle(string phrase)
    {
        return _documents.Where(d => d.Title.Contains(phrase, StringComparison.OrdinalIgnoreCase)).ToList();
    }

    public List<Magazine> GetMagazinesByFrequency(Frequency frequency)
    {
        return _documents.OfType<Magazine>()
            .Where(m => m.Frequency == frequency)
            .ToList();
    }
}
