# User Validation Application Report

## 1. **BankAccount.cs**
This file defines the `BankAccount` class, which includes a method for depositing money into the account. The `Deposit` method checks if the amount is negative and throws a `NegativeAmountException` if it is. This ensures that only valid deposit amounts are processed.

## 2. **FileReader.cs**
The `FileReader` class is responsible for reading the contents of a file. It has a method `ReadFile` that takes a filename as a parameter, reads the file's content, and prints it to the console.

## 3. **NegativeAmountException.cs**
This file defines a custom exception class `NegativeAmountException`, which inherits from the base `Exception` class. It is used to signal that an invalid (negative) amount has been provided for operations like deposits.

## 4. **UserValidationApp.csproj**
This is the project file for the User Validation Application. It specifies the project settings, including the output type, target framework, and nullable reference types.

## 5. **Program.cs**
The `Program` class contains the `Main` method, which serves as the entry point of the application. It includes several try-catch blocks to handle user input for age validation, division operations, and bank account deposits, ensuring that appropriate exceptions are caught and messages are displayed to the user.

## 6. **UserValidators.cs**
The `UserValidator` class contains a static method `ValidateAge`, which checks if a user is at least 18 years old. If the age is below 18, it throws an `ArgumentException`.
