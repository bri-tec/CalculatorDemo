using CalculatorClassLibrary;

namespace Calculator
{
    public class Factory
    {
        public static IMathsFunctions CreateMathFunctions()
        {
            return new MathsFunctions();
        }

        public static IHistoryModel CreateHistoryModel()
        {
            return new HistoryModel();
        }

        public static IHistoryFunctions CreateHistoryFunctions()
        {
            return new HistoryFunctions(CreateHistoryModel());
        }

        public static ICalculateHistoryTotal CreateHistoryCalculator()
        {
            return new CalculateHistoryTotal(CreateMathFunctions());
        }

        public static IStringConverter CreateStringConverter()
        {
            return new ImprovedConvertToHistory(CreateHistoryModel());
        }

        public static IConsoleOperations CreateSingleInputConsole()
        {
            return new SingleInputOperations(Factory.CreateHistoryCalculator());
        }
        
        public static IConsoleOperations CreateMultipleInputConsole()
        {
            return new MultipleInputStringOperations(Factory.CreateHistoryCalculator(), Factory.CreateStringConverter());
        }
    }
}
