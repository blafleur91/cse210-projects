using System;

public class Journal
{
        public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        // I originally had this set to one, but ChatGpt told me that the lists indexes do in fact work like python, despite googling it saying otherwise.
        // I tested and this does work, so I am annoyed almost everything I looked at through google said otherwise.
        int i = 0;
        int length = _entries.Count();
        // Previously I had this being i is greater then or equal to. That obviously wouldn't work. Also, less then or equal to doesn't work either.
        // I'm pretty sure this is exctly like python, where the length (.Count()) is one more then the indexes as it counts starting at one.
        while (i < length)
        {
            // previously I had Console.WriteLine(_entries[i]). Apparently that doesn't work. so the line below works by calling the list, giving it an index,
            // and running it through the display in entry.cs, which is what the the professors were wanting.
            _entries[i].Display();
            i++;
        }
    }

    public void SaveToFile(string file)
    {
        // I tried the below code but it just didn't work. apparently I was trying to run a list through a string reader, which doesn't work in C#
        // string filePath = file;
        // File.WriteAllLines(filePath, _entries);
        // Console.WriteLine($"Journal entries saved to {filePath}");

        var journalEntry = new List<string>();
        foreach (var entry in _entries)
        {
            string line = $"{entry._date}|{entry._prompText}|{entry._entryText}";
            journalEntry.Add(line);
        }
        // string filePath = file; 
        File.WriteAllLines(file, journalEntry); 
        Console.WriteLine($"Journal entries saved to {file}");
    }

    public void LoadFromFile(string file)
    {
        _entries.Clear();
        string[] fileLines = File.ReadAllLines(file);
        // Journal journal = new Journal();

        foreach (string fileLine in fileLines)
        {
            string[] parts = fileLine.Split('|');

            string date = parts[0];
            string promptText = parts[1];
            string entryText = parts[2];

            Entry entry = new Entry();
            entry._date = date;
            entry._prompText = promptText;
            entry._entryText = entryText;

            AddEntry(entry);
        }
    }
}