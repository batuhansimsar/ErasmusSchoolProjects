using System;

public static class UserValidator
{
    public static void ValidateAge(int age)
    {
        if (age < 18)
        {
            throw new ArgumentException("User must be at least 18 years old.");
        }
    }
}