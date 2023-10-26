class Journal
{
    private List<Entry> entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        entries.Add(entry);
    }

    public void DisplayEntries()
    {
        Console.WriteLine("\nJournal Entries:\n");
        foreach (var entry in entries)
        {
            Console.WriteLine($"Date: {entry.Date}");
            Console.WriteLine($"Prompt: {entry.Prompt}");
            Console.WriteLine($"Response: {entry.Response}\n");
        }
    }

    public void SaveToCsvFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            // Write the CSV header
            writer.WriteLine("Date, Prompt, Response");

            foreach (var entry in entries)
            {
                // Format the entry as a CSV line
                string csvLine = $"{entry.Date:yyyy-MM-dd HH:mm:ss}, \"{EscapeCsvValue(entry.Prompt)}\", \"{EscapeCsvValue(entry.Response)}\"";
                writer.WriteLine(csvLine);
            }
        }
        Console.WriteLine("Journal saved to CSV file.");
    }

    public void LoadFromCsvFile(string filename)
    {
        if (File.Exists(filename))
        {
            entries.Clear();
            using (StreamReader reader = new StreamReader(filename))
            {
                // Skip the header line
                reader.ReadLine();

                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] parts = line.Split(',');

                    if (parts.Length == 3)
                    {
                        DateTime date;
                        if (DateTime.TryParse(parts[0], out date))
                        {
                            string prompt = UnescapeCsvValue(parts[1].Trim());
                            string response = UnescapeCsvValue(parts[2].Trim());
                            Entry entry = new Entry(date, prompt, response);
                            entries.Add(entry);
                        }
                    }
                }
            }
            Console.WriteLine("Journal loaded from CSV file.");
        }
        else
        {
            Console.WriteLine("File not found. Journal not loaded.");
        }
    }

    private string EscapeCsvValue(string value)
    {
        // Escape double quotes by doubling them
        return value.Replace("\"", "\"\"");
    }

    private string UnescapeCsvValue(string value)
    {
        // Unescape doubled double quotes
        return value.Replace("\"\"", "\"");
    }
}
