class Journal
{
    private List<Entry> entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        entries.Add(entry);
    }

    public void DisplayEntries()
    {
        Console.WriteLine("Journal Entries:");
        foreach (var entry in entries)
        {
            Console.WriteLine(entry.FormatEntry());
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in entries)
            {
                string serializedEntry = entry.SerializeEntry();
                writer.WriteLine(serializedEntry);
            }
        }
        Console.WriteLine($"Saved journal to {filename}");
    }

    public void LoadFromFile(string filename)
    {
        List<Entry> loadedEntries = new List<Entry>();
        using (StreamReader reader = new StreamReader(filename))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                Entry entry = Entry.DeserializeEntry(line);
                if (entry != null)
                {
                    loadedEntries.Add(entry);
                }
            }
        }
        entries = loadedEntries;
        Console.WriteLine($"Loaded journal from {filename}");
    }
}