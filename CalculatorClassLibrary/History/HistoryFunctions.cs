using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorClassLibrary
{
    public class HistoryFunctions : IHistoryFunctions
    {
        IHistoryModel _historyModel;

        public HistoryFunctions(IHistoryModel historyModel)
        {
            _historyModel = historyModel;
        }

        public void CreateHistory(string equation)
        {
            _historyModel.History.Add(equation);
        }
        public void UpdateHistory(int index, string updatedEquation)
        {
            _historyModel.History[index] = updatedEquation;
        }
        public void DeleteHistory(int index)
        {
            _historyModel.History.RemoveAt(index);
        }
        public string GetHistory()
        {
            string history = "";

            foreach (string equation in _historyModel.History)
            {
                history += equation;
            }

            return history;
        }
    }
}
