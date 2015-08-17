using System;

public class StudentExamsNotFoundException : Exception
{
    public StudentExamsNotFoundException()
    {
    }

    public StudentExamsNotFoundException(string message)
        : base(message)
    {
    }

    public StudentExamsNotFoundException(string message, Exception inner)
        : base(message, inner)
    {
    }
}