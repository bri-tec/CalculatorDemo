using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorClassLibrary
{
    //Takes a single input from a user at a time, i.e a number or an operator
    public class SingleInputOperations : IConsoleOperations
    {
        
        ICalculateHistoryTotal _historyCalculator;
        public SingleInputOperations(ICalculateHistoryTotal historyCalculator)
        {
            _historyCalculator = historyCalculator;
        }

        public void Run(IHistoryModel historyModel)
        {
            historyModel.Initialise("History1");

            string? mathOperator = "";
            string? inputNumber = "";


            while (mathOperator != "=")
            {
                Console.WriteLine("Enter a number:");

                inputNumber = Console.ReadLine();

                Console.WriteLine("Enter an operator:");

                mathOperator = Console.ReadLine();

                historyModel.History.Add(inputNumber);

                if (mathOperator != "=")
                    historyModel.History.Add(mathOperator);
            }


            Console.WriteLine("Heres what I did:");
            Console.WriteLine("Answer: " + _historyCalculator.Calculate(historyModel, NotifyOfCalculation));
        }

        private static bool NotifyOfCalculation(string input)
        {
            Console.WriteLine(input);
            return true;
        }

    }
}
