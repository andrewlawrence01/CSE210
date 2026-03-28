using System;
using System.Collections.Generic;

namespace StoryBuilder
{
    public class Chapter
    {
        public int ChapterNumber { get; set; }
        public string Title { get; set; }

        private List<Event> _events = new List<Event>();

        public void AddEvent(Event e)
        {
            _events.Add(e);
        }

        public void DisplayChapterDetails()
        {
            Console.WriteLine($"Chapter {ChapterNumber}: {Title}");
            foreach (var e in _events)
                Console.WriteLine($" - {e.DescribeEvent()}");
        }
    }
}