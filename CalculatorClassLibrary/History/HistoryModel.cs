using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorClassLibrary
{
    /// <summary>
    /// A model used for storing the history of a current calculation
    /// </summary>
    public class HistoryModel : IHistoryModel
    {
        public List<string> History { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int OperationsCountCheck { get; private set; }

        public void Initialise(string historyName, string historyDescription = "")
        {
            History = new List<string>();
            Name = historyName;
        }

    }
}
