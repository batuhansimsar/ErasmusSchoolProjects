namespace DocumentLibrary.Models;

public class Magazine : Document
{
    public int IssueNumber { get; set; }
    public Frequency Frequency { get; set; }

    public Magazine() : base() { }

    public Magazine(string isbn, string title, int publicationYear, int pageCount, 
        int issueNumber, Frequency frequency)
        : base(isbn, title, publicationYear, pageCount)
    {
        IssueNumber = issueNumber;
        Frequency = frequency;
    }

    public override string Print()
    {
        return $"Printing magazine: {Title} - Issue {IssueNumber} ({Frequency})";
    }
}
