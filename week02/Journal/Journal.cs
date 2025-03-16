using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public string _filename = "journal.txt";
    public PromptGenerator _promptGen; // Store reference to PromptGenerator

    public Journal(PromptGenerator promptGen)
    {
        _promptGen = promptGen; // Use the same PromptGenerator instance
    }

    public void AddEntry()
    {
        string prompt = _promptGen.GetRandomPrompt(); // Use shared PromptGenerator
        
        if (prompt == "No prompts available.")
        {
            Console.WriteLine("\nNo prompts available. Please add prompts before writing.");
            return;
        }

        Console.WriteLine($"\nToday's Journal Prompt: {prompt}");
        Console.Write(">");
        string response = Console.ReadLine();

        string date = DateTime.Now.ToString("yyyy-MM-dd");
        Entry newEntry = new Entry { _date = date, _promptText = prompt, _entryText = response };
        _entries.Add(newEntry);

        Console.WriteLine("Your entry has been recorded!");
    }

    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No journal entries available!");
            return;
        }

        Console.WriteLine("\nYour Journal Entries:");
        foreach (Entry entry in _entries)
        {
            entry.DisplayEntry();
            Console.WriteLine();
        }
    }

    public void SaveToFile()
    {
        Console.Write("Enter filename to save (or press Enter to use default): ");
        string input = Console.ReadLine();
        string filename = string.IsNullOrWhiteSpace(input) ? _filename : input.Trim();

        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                writer.WriteLine($"{entry._date}~|~{entry._promptText}~|~{entry._entryText}");
            }
        }

        Console.WriteLine("Journal saved successfully!");
    }

   public void LoadFromFile()
    {
    Console.Write("Enter filename to load (or press Enter to use default): ");
    string input = Console.ReadLine();
    string filename = string.IsNullOrWhiteSpace(input) ? _filename : input.Trim();

    // ✅ Check if the file exists before clearing the journal
    if (!File.Exists(filename))
    {
        Console.WriteLine("⚠️ File not found! Make sure the file exists.");
        return;
    }

    // ✅ Now clear the existing entries (AFTER confirming file exists)
    _entries.Clear();

    try
    {
        using (StreamReader reader = new StreamReader(filename, System.Text.Encoding.UTF8))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split(new string[] { "~|~" }, StringSplitOptions.None);

                // ✅ Check if the line has exactly 3 parts (valid format)
                if (parts.Length == 3)
                {
                    _entries.Add(new Entry { _date = parts[0], _promptText = parts[1], _entryText = parts[2] });
                }
                else
                {
                    Console.WriteLine($"⚠️ Skipping invalid entry: {line}");
                }
            }
        }

        Console.WriteLine($"✅ Journal loaded successfully! {(_entries.Count > 0 ? $"{_entries.Count} entries found." : "No valid entries found.")}");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"❌ Error loading journal: {ex.Message}");
    }
    }

}
