using System;
using System.Collections.Generic;

namespace StoryBuilder
{
    public class PlotStructure
    {
        private List<string> _events = new List<string>();

        public void AddEvent(string e)
        {
            _events.Add(e);
        }

        public void DisplayPlot()
        {
            Console.WriteLine("Plot Events:");
            foreach (var e in _events)
                Console.WriteLine($" - {e}");
        }
    }
}