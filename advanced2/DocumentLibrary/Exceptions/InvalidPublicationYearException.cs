namespace DocumentLibrary.Exceptions;

public class InvalidPublicationYearException : Exception
{
    public InvalidPublicationYearException(string message) : base(message)
    {
    }
}
