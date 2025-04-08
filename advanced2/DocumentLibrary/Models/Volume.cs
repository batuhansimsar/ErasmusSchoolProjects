namespace DocumentLibrary.Models;

public class Volume : Book
{
    public int VolumeNumber { get; set; }
    public int TotalVolumes { get; set; }

    public Volume() : base() { }

    public Volume(string isbn, string title, int publicationYear, int pageCount, string author, 
        int volumeNumber, int totalVolumes)
        : base(isbn, title, publicationYear, pageCount, author)
    {
        VolumeNumber = volumeNumber;
        TotalVolumes = totalVolumes;
    }

    public override string Print()
    {
        return $"Printing volume {VolumeNumber} of {TotalVolumes}: {Title}";
    }
}
