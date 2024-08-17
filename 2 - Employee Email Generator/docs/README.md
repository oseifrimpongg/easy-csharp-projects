## Employee Email Generator

#### Description
This is a console application that generates email addresses for employees based on their names. Users input the number of employees and their names, and the application creates email addresses using a predefined domain.

#### Features
- **Employee Input**: Allows users to input the number of employees and their names.
- **Email Generation**: Generates email addresses in the format `firstnamelastname@domain.com`.
- **Domain Name**: Uses a default domain name (`bengi.com`) for email generation but can be customized.

#### Usage

##### How to Run
1. **Compile and Run Using .NET CLI**:
   - Ensure you have the [.NET SDK](https://dotnet.microsoft.com/download) installed.
   - Open a terminal and navigate to the directory containing the `Program.cs` file.
   - Use the following commands to compile and run the application:
     ```bash
     dotnet new console -o EmployeeEmailGenerator
     cp Program.cs EmployeeEmailGenerator
     cd EmployeeEmailGenerator
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
Employee Email Generator:

Enter the number of emails to be added:
3

Enter the names of the Employees separated by commas:
John Doe, Jane Smith, Bob Brown

Emails below:
johdoe@bengi.com
jansmith@bengi.com
bobrown@bengi.com
```

In this example:
- The user is prompted to enter the number of employees (`3`).
- The user then inputs the names of the employees separated by commas (`John Doe, Jane Smith, Bob Brown`).
- The application generates email addresses based on the names and displays them.

#### Prerequisite Knowledge
1. **Basic C# Syntax**: Understanding of C# syntax, including variable declarations, loops, and conditionals.
2. **Console Input/Output**: Familiarity with reading input from the console and displaying output.
3. **String Manipulation**: Knowledge of string operations such as splitting, trimming, and substring methods.
4. **Array Handling**: Ability to work with arrays, including iterating through elements and modifying them.
5. **Custom Methods**: Creating and using custom methods (`GetNumberOfEmployees`, `GetNamesOfEmployees`, `GenerateEmployeeEmail`).

#### Limitations
1. **Name Format**: The code assumes that each employee name consists of two words (first name and last name). If a name doesn't follow this format, the email generation might fail or produce unexpected results.
2. **Domain Name**: The domain name is hardcoded as `bengi.com` but can be modified in the code. There's no user input for custom domains.
3. **Case Sensitivity**: The code does not handle cases where the first name or last name might contain special characters or numbers.
4. **Handling of Names with Spaces**: The application only handles names separated by a single space. It does not account for names with multiple spaces or hyphenated names.

#### Contribution
- **How to Contribute**: Contributions are welcome! Please fork the repository and submit a pull request with your changes. Make sure to follow the coding standards and include tests if applicable.

#### License
- **License Information**: No specific license has been applied to this project.

#### Contact
- **Author Information**: [LinkedIn](https://linkedin.com/in/oseifrimpongg) | [X](https://x.com/oseifrimpongg)

#### Troubleshooting
- **Common Issues**: If you encounter issues, ensure you have the correct version of the .NET SDK installed and check for any syntax errors. Make sure the input follows the expected format.

#### Acknowledgments
- **Credits**: Special thanks to [freeCodeCamp](https://freecodecamp.org) and [Microsoft](https://microsoft.com) for their foundational C# course.

This structure should provide a clear and comprehensive overview of the **Employee Email Generator** project, including usage, prerequisites, limitations, and additional information.