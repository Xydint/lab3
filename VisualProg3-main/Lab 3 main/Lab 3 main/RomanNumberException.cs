using System;

public class RomanNumberException : Exception
{
    public RomanNumberException(string text) : base(text) { }
    public override string ToString()
    {
        string result = Message;
        return result;
    }
}
