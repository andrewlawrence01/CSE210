using System;
using System.Collections.Generic;

namespace StoryBuilder
{
    public class Story
    {
        public string Title { get; set; }

        private List<Chapter> _chapters = new List<Chapter>();
        private List<Character> _characters = new List<Character>();
        private List<Location> _locations = new List<Location>();

        public void AddChapter(Chapter chapter)
        {
            _chapters.Add(chapter);
        }

        public void AddCharacter(Character character)
        {
            _characters.Add(character);
        }

        public void AddLocation(Location location)
        {
            _locations.Add(location);
        }

        public void DisplayStorySummary()
        {
            Console.WriteLine($"\nStory: {Title}");

            Console.WriteLine("\nCharacters:");
            foreach (var c in _characters)
                Console.WriteLine(c.Describe());

            Console.WriteLine("\nChapters:");
            foreach (var ch in _chapters)
                ch.DisplayChapterDetails();
        }
    }
}