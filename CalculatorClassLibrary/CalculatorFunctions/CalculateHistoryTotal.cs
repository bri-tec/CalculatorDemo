using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorClassLibrary
{
    /// <summary>
    /// Calculates the total of the HistoryModel object.
    /// </summary>
    public class CalculateHistoryTotal : ICalculateHistoryTotal
    {
        
        private IMathsFunctions _mathsFunctions;
        public CalculateHistoryTotal(IMathsFunctions mathsFunctions) 
        {
            _mathsFunctions = mathsFunctions;
        }

        /// <summary>
        /// Runs through each element of the IHistoryModel list and performs
        /// the required operations to produce a total.
        /// </summary>
        /// <param name="historyModel"></param>
        /// <param name="notifyCaclProgress"></param>
        /// <returns></returns>
        public decimal Calculate(IHistoryModel historyModel, Func<string, bool> notifyCaclProgress)
        {
            decimal total = 0;
            string lastOperator = "+";

            foreach (string equation in historyModel.History)
            {
                switch (equation)
                {
                    case "+":
                        lastOperator = equation;                        
                        break; 
                    case "-":
                        lastOperator = equation;
                        break;
                    case "*":
                        lastOperator = equation;                        
                        break;
                    case "/":
                        lastOperator = equation;                         
                        break;
                    default:
                        //its a number
                        var totalOutput = GetTotalFromLastOperatorAndValue(lastOperator, decimal.Parse(equation), total, _mathsFunctions);
                        notifyCaclProgress($"{equation}{lastOperator}{total}={totalOutput}");
                        total = totalOutput;
                        break;
                }
                
            }

            return total;
        }

        private decimal GetTotalFromLastOperatorAndValue(string lastOperator, decimal value, decimal total, IMathsFunctions maths)
        {
            switch (lastOperator)
            {
                case "+":
                    return maths.Add(total, value);                    
                case "-":
                    return maths.Subtract(total, value);                    
                case "*":
                    return maths.Multiply(total, value);                    
                case "/":
                    return maths.Divide(total, value);
                default:
                    return total;                    
            }
        }
    }
}
