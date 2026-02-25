using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time you stood up for someone.",
        "Think of a time you did something difficult.",
        "Think of a time you helped someone."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this meaningful?",
        "What did you learn?",
        "How did you feel afterward?",
        "How can you apply this lesson?"
    };

    private Random _random = new Random();

    public ReflectingActivity()
        : base("Reflecting Activity",
              "This activity will help you reflect on moments of strength.")
    {
    }

    protected override void Run()
    {
        Console.WriteLine("\nConsider this prompt:\n");
        Console.WriteLine($"--- {_prompts[_random.Next(_prompts.Count)]} ---");
        Console.WriteLine("\nPress enter when ready.");
        Console.ReadLine();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine($"\n{_questions[_random.Next(_questions.Count)]}");
            ShowSpinner(5);
        }
    }
}