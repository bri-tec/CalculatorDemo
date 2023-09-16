namespace CalculatorClassLibrary
{
    public interface IHistoryModel
    {
        string Description { get; set; }
        List<string> History { get; set; }
        string Name { get; set; }
        int OperationsCountCheck { get; }

        void Initialise(string historyName, string historyDescription = "");
    }
}