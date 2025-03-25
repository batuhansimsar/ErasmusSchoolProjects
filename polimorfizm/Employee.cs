using System;

namespace EmployeeManagement
{
    // Base abstract class for all employee types
    public abstract class Employee
    {
        // Private fields for employee properties
        private int _id;
        private string? _name;
        private int _age;
        private string? _gender;
        private decimal _salary;

        // Property for employee ID
        public int Id 
        {
            get { return _id; }
            set { _id = value; }
        }

        // Property for employee name
        public string? Name
        {
            get { return _name; }
            set { _name = value; }
        }

        // Property for employee age
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        // Property for employee gender
        public string? Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        // Property for employee salary
        public decimal Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }

        // Default constructor
        public Employee()
        {
        }

        // Parameterized constructor
        public Employee(int id, string name, int age, string gender, decimal salary)
        {
            Id = id;
            Name = name;
            Age = age;
            Gender = gender;
            Salary = salary;
        }

        // Virtual method for salary increase that can be overridden by derived classes
        public virtual void IncreaseSalary(decimal amount)
        {
            Salary += amount;
        }

        // Override ToString method to provide meaningful string representation
        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, Age: {Age}, Gender: {Gender}, Salary: {Salary:C}";
        }
    }
} 