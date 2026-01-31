// Entry.cs
public class Entry
{
    public string Date { get; }
    public string Prompt { get; }
    public string Response { get; }
    public string Mood { get; }

    public Entry(string date, string prompt, string response, string mood)
    {
        Date = date;
        Prompt = prompt;
        Response = response;
        Mood = mood;
    }

    public void Display()
    {
        Console.WriteLine($"{Date}");
        Console.WriteLine($"Prompt: {Prompt}");
        Console.WriteLine($"Response: {Response}");
        Console.WriteLine($"Mood: {Mood}/5");
        Console.WriteLine();
    }

    public string ToFileFormat()
    {
        return $"{Date}|{Prompt}|{Response}|{Mood}";
    }

    public static Entry FromFileFormat(string line)
    {
        string[] parts = line.Split("|");
        return new Entry(parts[0], parts[1], parts[2], parts[3]);
    }
}