### Simple Console-Based Calculator

#### Description
This is a simple console-based calculator application written in C#. It performs basic arithmetic operations (addition, subtraction, multiplication, division, and modulo) based on user input.

#### Features
- **Supported Operations**: Addition, subtraction, multiplication, division, modulo.
- **User Input**: Validates user input for numbers and operations.

#### Usage

##### How to Run
1. **Compile and Run Using .NET CLI**:
   - Ensure you have the [.NET SDK](https://dotnet.microsoft.com/download) installed.
   - Open a terminal and navigate to the directory containing the `Program.cs` file.
   - Use the following commands to compile and run the application:
     ```bash
     dotnet new console -o SimpleCalculator
     cp Program.cs SimpleCalculator
     cd SimpleCalculator
     dotnet run
     ```

2. **Compile and Run Using Visual Studio**:
   - Open Visual Studio and select `File > Open > Project/Solution`.
   - Navigate to the directory containing the `Program.cs` file and open it.
   - Build and run the project by pressing `F5` or using the `Start` button.

##### Example
Here’s an example of how the application interacts with users:

**Terminal Output:**
```
Simple Console Calculator Application:

Enter your first number:
5

Enter your operation:
[+, -, x, /, %]
+

Enter your second number:
3

The results of the operation:
5 + 3 = 8
```

#### Prerequisite Knowledge
1. **Basic C# Syntax**: Understanding of C# syntax, including variable declarations, loops, and conditionals.
2. **Console Input/Output**: Familiarity with reading input from the console and displaying output.
3. **Data Types and Parsing**: Knowledge of data types (`int`, `string`) and methods for parsing and converting data types (e.g., `int.TryParse`).
4. **String Operations**: Understanding of basic string operations and comparisons.
5. **Control Structures**: Usage of `do-while` loops and `switch` statements.
6. **Array Handling**: Ability to work with arrays, including searching and checking for values (e.g., `operations.Contains`).

#### Limitations
1. **Division by Zero**: The code does not handle division by zero, which will cause a runtime error if the user inputs zero as the second number for division.
2. **Non-Numeric Input Handling**: If the user enters non-numeric values or invalid operations, they will be prompted to re-enter values, but there is no limit on the number of attempts.
3. **No Error Handling for `int` Overflow**: The code does not account for cases where integer overflow might occur with large numbers.

#### Contribution
- **How to Contribute**: Contributions are welcome! Please fork the repository and submit a pull request with your changes. Make sure to follow the coding standards and include tests if applicable.

#### License
- **License Information**: No specific license has been applied to this project.

#### Contact
- **Author Information**: [LinkedIn](https://linkedin.com/in/oseifrimpongg) | [X](https://x.com/oseifrimpongg)

#### Troubleshooting
- **Common Issues**: If you encounter issues, ensure you have the correct version of the .NET SDK installed and check for any syntax errors.

#### Acknowledgments
- **Credits**: Special thanks to [freeCodeCamp](https://freecodecamp.org) and [Microsoft](https://microsoft.com) for their foundational C# course.