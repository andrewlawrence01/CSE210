using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people you appreciate?",
        "What are your strengths?",
        "What makes you happy?"
    };

    private Random _random = new Random();

    public ListingActivity()
        : base("Listing Activity",
              "This activity helps you list positive things in your life.")
    {
    }

    protected override void Run()
    {
        Console.WriteLine("\nList as many responses as you can to:");
        Console.WriteLine($"--- {_prompts[_random.Next(_prompts.Count)]} ---");
        Console.Write("You may begin in: ");
        ShowCountdown(5);

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        int count = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            count++;
        }

        Console.WriteLine($"\nYou listed {count} items!");
    }
}