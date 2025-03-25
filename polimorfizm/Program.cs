using System;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeManagement
{
    class Program
    {
        // Constant for company's annual budget
        private const decimal ANNUAL_BUDGET = 1000000;
        
        // List to store all employees
        private static List<Employee> employees = new List<Employee>();

        // Main entry point of the application
        static void Main(string[] args)
        {
            // Initialize employee list with sample data
            InitializeEmployees();

            // Main program loop
            while (true)
            {
                ShowMenu();
                string? choice = Console.ReadLine();

                // Handle user menu selection
                switch (choice)
                {
                    case "1":
                        ListAllEmployees();
                        break;
                    case "2":
                        ListEmployeesBySalary();
                        break;
                    case "3":
                        FindEmployeeById();
                        break;
                    case "4":
                        IncreaseSalaryById();
                        break;
                    case "5":
                        IncreaseAllSalaries();
                        break;
                    case "6":
                        ShowAnnualSummary();
                        break;
                    case "0":
                        Console.WriteLine("Exiting...");
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }

        // Initialize the employee list with sample data
        private static void InitializeEmployees()
        {
            // Add different types of employees to demonstrate polymorphism
            employees.Add(new ProjectManager(1, "John Smith", 35, "Male", 5000, 3));
            employees.Add(new Analyst(2, "Mary Johnson", 28, "Female", 4000, 5));
            employees.Add(new Developer(3, "David Brown", 30, "Male", 4500, 4));
            employees.Add(new RemoteDeveloper(4, "Sarah Wilson", 32, "Female", 4800, 5, 100));
        }

        // Display the main menu options
        private static void ShowMenu()
        {
            // Set menu color to cyan for better visibility
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nEmployee Management System");
            Console.WriteLine("1. List all employees");
            Console.WriteLine("2. List employees by salary (descending)");
            Console.WriteLine("3. Find employee by ID");
            Console.WriteLine("4. Increase salary by ID");
            Console.WriteLine("5. Increase all salaries");
            Console.WriteLine("6. Show annual summary");
            Console.WriteLine("0. Exit");
            Console.Write("Choose an option: ");
            Console.ResetColor();
        }

        // Display all employees in the system
        private static void ListAllEmployees()
        {
            Console.WriteLine("\nAll Employees:");
            foreach (var employee in employees)
            {
                Console.WriteLine(employee);
            }
        }

        // Display employees sorted by salary in descending order
        private static void ListEmployeesBySalary()
        {
            Console.WriteLine("\nEmployees sorted by salary (highest to lowest):");
            foreach (var employee in employees.OrderByDescending(e => e.Salary))
            {
                Console.WriteLine(employee);
            }
        }

        // Find and display an employee by their ID
        private static void FindEmployeeById()
        {
            Console.Write("\nEnter employee ID: ");
            // Try to parse user input as integer
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                // Search for employee with matching ID
                var employee = employees.FirstOrDefault(e => e.Id == id);
                if (employee != null)
                {
                    Console.WriteLine(employee);
                }
                else
                {
                    Console.WriteLine("Employee not found.");
                }
            }
            else
            {
                Console.WriteLine("Invalid ID format.");
            }
        }

        // Increase salary for a specific employee by ID
        private static void IncreaseSalaryById()
        {
            Console.Write("\nEnter employee ID: ");
            // Try to parse user input as integer
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                // Find employee with matching ID
                var employee = employees.FirstOrDefault(e => e.Id == id);
                if (employee != null)
                {
                    Console.Write("Enter amount to increase: ");
                    // Try to parse salary increase amount
                    if (decimal.TryParse(Console.ReadLine(), out decimal amount))
                    {
                        employee.IncreaseSalary(amount);
                        Console.WriteLine("Salary updated successfully.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid amount format.");
                    }
                }
                else
                {
                    Console.WriteLine("Employee not found.");
                }
            }
            else
            {
                Console.WriteLine("Invalid ID format.");
            }
        }

        // Increase salaries for all employees
        private static void IncreaseAllSalaries()
        {
            Console.Write("\nEnter amount to increase all salaries: ");
            // Try to parse salary increase amount
            if (decimal.TryParse(Console.ReadLine(), out decimal amount))
            {
                // Apply increase to all employees
                foreach (var employee in employees)
                {
                    employee.IncreaseSalary(amount);
                }
                Console.WriteLine("All salaries updated successfully.");
            }
            else
            {
                Console.WriteLine("Invalid amount format.");
            }
        }

        // Display annual budget summary
        private static void ShowAnnualSummary()
        {
            // Calculate total annual salaries and difference from budget
            decimal totalAnnualSalaries = employees.Sum(e => e.Salary * 12);
            decimal difference = ANNUAL_BUDGET - totalAnnualSalaries;

            // Display budget information
            Console.WriteLine($"\nAnnual Budget: {ANNUAL_BUDGET:C}");
            Console.WriteLine($"Total Annual Salaries: {totalAnnualSalaries:C}");

            // Show difference in appropriate color (green for positive, red for negative)
            if (difference >= 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Remaining Budget: {difference:C} (Positive)");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Budget Deficit: {difference:C} (Negative)");
            }
            Console.ResetColor();
        }
    }
}
