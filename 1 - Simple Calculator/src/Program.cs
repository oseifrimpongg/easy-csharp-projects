Console.WriteLine("Simple Console Calculator Application:\n");

string? readResult;

bool isValidNumber = false;
int firstNumber = 0;
int secondNumber = 0;


string[] operations = { "+", "x", "-", "/", "%" };
bool isValidOperation = false;
string chosenOperation = "+";


Console.WriteLine("Enter your first number:");
do
{
    readResult = Console.ReadLine();
    if (readResult != null && int.TryParse(readResult, out firstNumber))
    {
        isValidNumber = true;
        break;
    }
    else Console.WriteLine("Enter a numeric value:");

} while (isValidNumber == false);


Console.WriteLine("Enter your operation:\n[+, -, x, /, %]");
do
{
    readResult = Console.ReadLine();
    if (readResult != null && operations.Contains(readResult))
    {
        chosenOperation = readResult;
        isValidOperation = true;
        break;
    }
    else Console.WriteLine("Enter a valid operation below:\n[+, x, /, -, %]");

} while (isValidOperation == false);


Console.WriteLine("Enter your second number:");
do
{
    isValidNumber = false;
    readResult = Console.ReadLine();
    if (readResult != null && int.TryParse(readResult, out secondNumber))
    {
        isValidNumber = true;
        break;
    }
    else Console.WriteLine("Enter a numeric value:");
} while (isValidNumber == false);

DoCalculation(firstNumber, secondNumber, chosenOperation);

void DoCalculation(int firstNumber, int secondNumber, string chosenOperation)
{
    int result = 0;

    switch (chosenOperation)
    {
        case "+":
            result = firstNumber + secondNumber;
            break;

        case "-":
            result = firstNumber - secondNumber;
            break;

        case "/":
            result = firstNumber / secondNumber;
            break;

        case "%":
            result = firstNumber % secondNumber;
            break;

        case "x":
            result = firstNumber * secondNumber;
            break;
    }

    Console.WriteLine($"The results of the operation:\n{firstNumber} {chosenOperation} {secondNumber} = {result}");
}