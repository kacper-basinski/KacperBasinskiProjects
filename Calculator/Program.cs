// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello!");
Console.WriteLine("Input the first number:");
int firstNumber = int.Parse(Console.ReadLine());

Console.WriteLine("Input the second number:");
int secondNumber = int.Parse(Console.ReadLine());

Console.WriteLine("What would you like to do with them?");
Console.WriteLine("[A]dd numbers");
Console.WriteLine("[S]ubtract numbers");
Console.WriteLine("[M]ultiply numbers");
Console.WriteLine("[D]ivide numbers");
Console.WriteLine("[E]xit program");

bool isValidInput = false;

while (!isValidInput)
{
    string userSelection = Console.ReadLine().ToLower();

    switch (userSelection)
    {
        case "a":
            AddNumbers(firstNumber, secondNumber);
            isValidInput = true;
            break;
        case "s":
            SubtractNumbers(firstNumber, secondNumber);
            isValidInput = true;
            break;
        case "m":
            MultiplyNumbers(firstNumber, secondNumber);
            isValidInput = true;
            break;
        case "d":
            DivideNumbers(firstNumber, secondNumber);
            isValidInput = true;
            break;
        case "e":
            isValidInput = true;
            Console.WriteLine("Exiting the application...");
            Environment.Exit(0);
            break;
        default: Console.WriteLine("Please provide options of A (for addition), S (for subtraction), M (for multiplication), or D (for division)."); break;
    }
}



void AddNumbers(int firstInput, int secondInput)
{
    int sum = firstInput + secondInput;
    Console.WriteLine($"{firstNumber} + {secondNumber} = {sum}");
    Console.WriteLine("Press any key to close.");
}
void SubtractNumbers(int firstInput, int secondInput)
{
    int difference = firstInput - secondInput;
    Console.WriteLine($"{firstNumber} - {secondNumber} = {difference}");
    Console.WriteLine("Press any key to close.");
}
void MultiplyNumbers(int firstInput, int secondInput)
{
    int product = firstInput * secondInput;
    Console.WriteLine($"{firstNumber} x {secondNumber} = {product}");
    Console.WriteLine("Press any key to close.");
}
void DivideNumbers(int firstInput, int secondInput)
{
    int quotient = firstInput / secondInput;
    Console.WriteLine($"{firstNumber} / {secondNumber} = {quotient}");
    Console.WriteLine("Press any key to close.");
}

Console.ReadLine();