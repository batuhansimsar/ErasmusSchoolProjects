using System;

class Program
{
    static void Main(string[] args)
    {
        // Test user age validation
        try
        {
            Console.WriteLine("Enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());
            UserValidator.ValidateAge(age); // Validate age
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }

        // Test division
        try
        {
            Console.WriteLine("Enter the first number:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int result = num1 / num2;
            Console.WriteLine($"Result: {result}");
        }
        catch (ArithmeticException)
        {
            Console.WriteLine("Cannot divide by zero.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Please enter valid integers.");
        }

        // Test bank account
        try
        {
            BankAccount account = new BankAccount();
            Console.WriteLine("Enter an amount to deposit:");
            double amount = Convert.ToDouble(Console.ReadLine());
            account.Deposit(amount); // Deposit amount
        }
        catch (NegativeAmountException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}