using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorClassLibrary
{
    //This class runs the Console UI for the string input calculation
    public class MultipleInputStringOperations : IConsoleOperations
    {
        ICalculateHistoryTotal _historyCalculator;
        IStringConverter _stringConverter;
        

        public MultipleInputStringOperations(ICalculateHistoryTotal historyCalculator, IStringConverter stringConverter)
        {
            _historyCalculator = historyCalculator;
            _stringConverter = stringConverter;
        }

        public void Run(IHistoryModel historyModel)
        {
            historyModel.Initialise("History2");
            _stringConverter.HistoryModel = historyModel;

            Console.WriteLine("Enter a calculation for me to calculate (or type 'e' to exit):");
            string lastInput = "";

            while (true)
            {
                lastInput = Console.ReadLine();

                if (lastInput == "e")
                    break;
                else
                {
                    _stringConverter.Convert(lastInput);
                    
                    Console.WriteLine("Heres what I did:");
                    Console.WriteLine("Answer: " + _historyCalculator.Calculate(_stringConverter.HistoryModel, NotifyOfCalculation));
                    Console.WriteLine("Enter another calculation for me to calculate (or type 'e' to exit):");
                }
            }
            
        }

        private static bool NotifyOfCalculation(string input)
        {
            Console.WriteLine(input);
            return true;
        }
    }
}
