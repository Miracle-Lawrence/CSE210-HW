public class Entry
{
    public string _date;
    public string _time; // Added time to store entry time
    public string _mood; // Added mood tracking feature
    public string _promptText;
    public string _entryText;

    public Entry()
    {
    }

    public void DisplayEntry()
    {
        Console.WriteLine($"Date: {_date} | Time: {_time} | Mood: {_mood}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Entry: {_entryText}");
    }
}
