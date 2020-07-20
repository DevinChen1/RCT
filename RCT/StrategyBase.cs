namespace RCT
{
    public class StrategyBase
    {
        public MainEngine mainEngine { get; set; }
        public EventEngine eventEngine { get; set; }
        public string strategyName { get; set; }
    }
}