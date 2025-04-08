namespace DocumentLibrary.Models;

public abstract class Document
{
    public string ISBN { get; set; }
    public string Title { get; set; }
    public int PublicationYear { get; set; }
    public int PageCount { get; set; }

    protected Document() { }

    protected Document(string isbn, string title, int publicationYear, int pageCount)
    {
        ISBN = isbn;
        Title = title;
        PublicationYear = publicationYear;
        PageCount = pageCount;
    }

    public abstract string Print();

    public override string ToString()
    {
        return $"ISBN: {ISBN}, Title: {Title}, Year: {PublicationYear}, Pages: {PageCount}";
    }

    public override bool Equals(object? obj)
    {
        if (obj is Document other)
        {
            return ToString() == other.ToString();
        }
        return false;
    }

    public override int GetHashCode()
    {
        return ToString().GetHashCode();
    }

    public static bool operator ==(Document? left, Document? right)
    {
        if (ReferenceEquals(left, null))
            return ReferenceEquals(right, null);
        return left.Equals(right);
    }

    public static bool operator !=(Document? left, Document? right)
    {
        return !(left == right);
    }
}
