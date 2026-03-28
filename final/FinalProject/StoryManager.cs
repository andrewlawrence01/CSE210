using System;
using System.Collections.Generic;

namespace StoryBuilder
{
    public class StoryManager
    {
        private Story _story = new Story();

        public void StartProgram()
        {
            bool running = true;

            while (running)
            {
                DisplayMenu();
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        CreateStory();
                        break;
                    case "2":
                        AddCharacterMenu();
                        break;
                    case "3":
                        AddLocation();
                        break;
                    case "4":
                        AddChapterMenu();
                        break;
                    case "5":
                        _story.DisplayStorySummary();
                        break;
                    case "6":
                        running = false;
                        break;
                }
            }
        }

        public void DisplayMenu()
        {
            Console.WriteLine("\n--- Story Builder ---");
            Console.WriteLine("1. Create New Story");
            Console.WriteLine("2. Add Character");
            Console.WriteLine("3. Add Location");
            Console.WriteLine("4. Add Chapter");
            Console.WriteLine("5. View Story Summary");
            Console.WriteLine("6. Exit");
            Console.Write("Select an option: ");
        }

        public void CreateStory()
        {
            Console.Write("Enter story title: ");
            _story.Title = Console.ReadLine();
        }

        public void AddCharacterMenu()
        {
            Console.WriteLine("1. Protagonist\n2. Antagonist\n3. Supporting Character");
            string choice = Console.ReadLine();

            Console.Write("Enter name: ");
            string name = Console.ReadLine();

            Character character;

            switch (choice)
            {
                case "1":
                    character = new Protagonist(name);
                    break;
                case "2":
                    character = new Antagonist(name);
                    break;
                default:
                    character = new SupportingCharacter(name);
                    break;
            }

            _story.AddCharacter(character);
        }

        public void AddLocation()
        {
            Console.Write("Enter location name: ");
            string name = Console.ReadLine();

            Location location = new Location(name);
            _story.AddLocation(location);
        }

        public void AddChapterMenu()
        {
            Chapter chapter = new Chapter();

            Console.Write("Chapter number: ");
            chapter.ChapterNumber = int.Parse(Console.ReadLine());

            Console.Write("Chapter title: ");
            chapter.Title = Console.ReadLine();

            _story.AddChapter(chapter);
        }
    }
}