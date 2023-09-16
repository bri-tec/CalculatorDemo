using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorClassLibrary
{
    /// <summary>
    /// This is the improved version of the ConvertToHistory class
    /// that deals with the = sign at the end of the input string.
    /// </summary>
    public class ImprovedConvertToHistory : IStringConverter
    {
        IHistoryModel _historyModel;

        public IHistoryModel HistoryModel
        {
            get { return _historyModel; }
            set { _historyModel = value; }
        }


        public ImprovedConvertToHistory(IHistoryModel historyModel)
        {
            _historyModel = historyModel;
        }

        public bool Convert(string input)
        {
            _historyModel.History.Clear();

            string number = "";
            bool lastCharWasOperator = false;

            char[] chars = input.ToCharArray();

            for (int i =0; i < chars.Length; i++)
            {
                char c = chars[i];
                //decimal point
                if (c == '.' || int.TryParse(c.ToString(), out _))
                {
                    number += c;
                    lastCharWasOperator = false;

                    //if last char, add number to list
                    if (i == chars.Length - 1)
                        _historyModel.History.Add(number);
                    
                }
                else if (c == '=')
                {
                    _historyModel.History.Add(number);
                    break;
                }
                else if (!lastCharWasOperator)
                {
                    _historyModel.History.Add(number);
                    _historyModel.History.Add(c.ToString());
                    number = "";
                    lastCharWasOperator = true;
                }
                else
                {
                    return false;
                }
            }

            return true;
        }

        
    }
}
