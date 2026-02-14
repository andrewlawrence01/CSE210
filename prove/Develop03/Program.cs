using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // ===============================
        // EXCEEDING REQUIREMENTS:
        // - Loads scriptures from a file (scriptures.txt)
        // - Randomly selects a scripture from a library
        // - Only hides words that are not already hidden
        // ===============================

        List<Scripture> scriptures = LoadScriptures("scriptures.txt");

        if (scriptures.Count == 0)
        {
            Console.WriteLine("No scriptures found.");
            return;
        }

        Random random = new Random();
        Scripture scripture = scriptures[random.Next(scriptures.Count)];

        while (!scripture.AllWordsHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress ENTER to continue or type 'quit' to exit.");

            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                return;

            scripture.HideRandomWords(3);
        }

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("\nAll words are hidden. Program ending.");
    }

    static List<Scripture> LoadScriptures(string filename)
    {
        List<Scripture> scriptures = new List<Scripture>();

        if (!File.Exists(filename))
            return scriptures;

        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            // Format: Book|Chapter|Verse|EndVerse(optional)|Text
            string[] parts = line.Split('|');

            if (parts.Length == 5)
            {
                string book = parts[0];
                int chapter = int.Parse(parts[1]);
                int verse = int.Parse(parts[2]);
                int endVerse = int.Parse(parts[3]);
                string text = parts[4];

                Reference reference = new Reference(book, chapter, verse, endVerse);
                scriptures.Add(new Scripture(reference, text));
            }
            else if (parts.Length == 4)
            {
                string book = parts[0];
                int chapter = int.Parse(parts[1]);
                int verse = int.Parse(parts[2]);
                string text = parts[3];

                Reference reference = new Reference(book, chapter, verse);
                scriptures.Add(new Scripture(reference, text));
            }
        }

        return scriptures;
    }
}