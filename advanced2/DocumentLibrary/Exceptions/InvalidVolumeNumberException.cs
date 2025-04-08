namespace DocumentLibrary.Exceptions;

public class InvalidVolumeNumberException : Exception
{
    public InvalidVolumeNumberException(string message) : base(message)
    {
    }
}
