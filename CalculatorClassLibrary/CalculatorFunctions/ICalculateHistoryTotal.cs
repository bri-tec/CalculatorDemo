namespace CalculatorClassLibrary
{
    public interface ICalculateHistoryTotal
    {
        decimal Calculate(IHistoryModel historyModel, Func<string, bool> notifyCaclProgress);
    }
}