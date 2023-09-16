using Calculator;
using CalculatorClassLibrary;

namespace MyProject;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please select a mode:\n\n1. Single Input Calculator\n2. String Input Calculator\nEnter anything else to exit");

        string input = Console.ReadLine();


        if (input == "1") //Option 1 allows the user to enter one number at a time
        {
            IConsoleOperations consoleOperations = Factory.CreateSingleInputConsole();         
            consoleOperations.Run(Factory.CreateHistoryModel());
        }
        else if (input == "2") //option 2 allows the user to enter a calculation as a string
        {
            IConsoleOperations consoleOperations = Factory.CreateMultipleInputConsole();
            consoleOperations.Run(Factory.CreateHistoryModel());
        }
        else
        {
            Console.WriteLine("Ok Goodbye");
        }

    }

    
}