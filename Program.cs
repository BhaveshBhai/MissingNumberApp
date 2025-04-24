using MissingNumberApp.Interfaces;
using MissingNumberApp.Services;

bool continueApp = true;

IInputProvider inputProvider = new ConsoleInputProvider();
IMissingNumbersFinder finder = new RangeMissingNumberProvider();
IOutputProvider outputWriter = new ConsoleOutputProvider();

while (continueApp)
{
    int[] numbers = inputProvider.GetInput();
    var missingNumbers = finder.FindMissingNumbers(numbers);
    outputWriter.WriteOutput(missingNumbers);

    Console.WriteLine("Do you want to continue? (Y/N): ");
    string? choice = Console.ReadLine()?.Trim().ToLower();

    continueApp = choice == "y";
}

Console.WriteLine("Thank you! Exiting app...");
