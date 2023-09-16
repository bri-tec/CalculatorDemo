namespace CalculatorClassLibrary
{
    public interface IStringConverter
    {
        bool Convert(string input);

        IHistoryModel HistoryModel { get; set; }
    }
}