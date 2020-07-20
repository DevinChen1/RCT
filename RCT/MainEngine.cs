using System.Collections.Generic;

namespace RCT
{
    public class MainEngine
    {
        private static EventEngine eventEngine = null;
        public MainEngine() 
        {
            if (eventEngine==null)
            {
                eventEngine = new EventEngine();
            }
            eventEngine.start();
        }

        private Dictionary<string, StrategyBase> strategys { get; set; }
 
    }
}