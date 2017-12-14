using System;
using System.Diagnostics.Tracing;
using System.Linq;

namespace ETW1
{
    [EventSource(Name = "ChickenEventCounterExample")]
    public sealed class ETWLogger : EventSource
    {
        public static ETWLogger Log = new ETWLogger();
        private EventCounter _counter;
        

        private ETWLogger()
        {
            this._counter = new EventCounter("chickens", this);
        }

        public void CountChickens(float numberOfChickens)
        {
            WriteEvent(1, "counting chickens before they've hatched", numberOfChickens);
            this._counter.WriteMetric(numberOfChickens);
        }
    }
}
