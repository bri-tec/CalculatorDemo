namespace CalculatorClassLibrary
{
    public interface IHistoryFunctions
    {
        void CreateHistory(string equation);
        void DeleteHistory(int index);
        string GetHistory();
        void UpdateHistory(int index, string updatedEquation);
    }
}