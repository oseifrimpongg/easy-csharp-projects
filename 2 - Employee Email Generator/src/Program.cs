Console.WriteLine("Employee Email Generator:\n");

int numberOfEmployees = GetNumberOfEmployees("Enter the number of emails to be added:");
string[] employeeData = GetNamesOfEmployees("Enter the names of the Employees separated by commas", numberOfEmployees);

Console.WriteLine("\nEmails below:");
GenerateEmployeeEmail(employeeData);

// Get the number of employees, do number and type checking
int GetNumberOfEmployees(string displayString)
{
    Console.WriteLine(displayString);

    bool isValidNumber = false;
    int givenNumber = 0;
    do
    {
        string? readResult = Console.ReadLine();
        if (readResult != null && int.TryParse(readResult, out givenNumber))
        {
            isValidNumber = true;
            break;
        }
        else Console.WriteLine("Please provide a numeric value!");
    } while (isValidNumber == false);

    return givenNumber;
}


// Generate the total number of employee data
string[] GetNamesOfEmployees(string displayString, int numberOfEmployees)
{
    Console.WriteLine(displayString);

    string? readResult;
    bool isValidInput = false;

    do
    {
        readResult = Console.ReadLine();

        if (!string.IsNullOrWhiteSpace(readResult))
        {
            int commaCount = readResult.Count(c => c == ',');

            if (commaCount == numberOfEmployees - 1)
            {
                isValidInput = true;
            }
            else Console.WriteLine($"Please provide the names of {numberOfEmployees} employees separated by commas");
        }
        else Console.WriteLine("Please provide names of separated by commas");

    } while (!isValidInput);

    string[] employeeNames = (readResult ?? "").Split(",");
    return employeeNames;

}

void GenerateEmployeeEmail(string[] employeeData, string domainName = "bengi.com")
{
    for (int i = 0; i < employeeData.Length; i++)
    {
        employeeData[i] = employeeData[i].Trim();
        string firstName = employeeData[i].Split(" ")[0].Substring(0, 3).ToLower();
        string lastName = employeeData[i].Split(" ")[1].ToLower();

        string employeeEmail = $"{firstName}{lastName}@{domainName}";
        Console.WriteLine(employeeEmail);
    }

};