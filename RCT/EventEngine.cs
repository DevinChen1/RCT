using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RCT
{
    public class EventEngine
    {
        private bool _active = false;
        public Queue<EventData> _queue { get; set; }
        Task task = null;
        public List<HanderBase> _handlers { get; set; }
        public void start()
        {
            _active = true;
            task = new Task(() => run());
            task.Start();
        }
        public void stop()
        {
            _active = false;
            task.Wait();
        }
        private void run()
        {
            while (_active)
            {
                process(_queue.Dequeue());
            }
        }
        public void process(EventData eventData)
        {
            _handlers.Where(x => x.HanderType == eventData.Type).ToList().ForEach(handler => handler.Execute(eventData));
        }

    }

    public class HanderBase
    {
        public EventType HanderType { get; set; }
        public void Execute (EventData data)
        { 
        }
    }

    public class EventData
    {
        public EventType Type { get; set; }
        public string dataJson { get; set; }
    }
    public  enum EventType
    {
        Tick,
    }
}