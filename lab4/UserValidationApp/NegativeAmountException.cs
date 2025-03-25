using System;

public class NegativeAmountException : Exception
{
    public NegativeAmountException(string message) : base(message) { }
}