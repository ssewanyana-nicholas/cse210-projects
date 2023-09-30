class Entry
{
    public DateTime Date { get; set; }
    public string Prompt { get; set; }
    public string Response { get; set; }

    public Entry(DateTime date, string prompt, string response)
    {
        Date = date;
        Prompt = prompt;
        Response = response;
    }

    public string FormatEntry()
    {
        return $"Date: {Date:yyyy-MM-dd}\nPrompt: {Prompt}\nResponse: {Response}\n";
    }

    public string SerializeEntry()
    {
        return $"{Date:yyyy-MM-dd}|{Prompt}|{Response}";
    }

    public static Entry DeserializeEntry(string serializedEntry)
    {
        string[] parts = serializedEntry.Split('|');
        if (parts.Length == 3 && DateTime.TryParse(parts[0], out DateTime date))
        {
            return new Entry(date, parts[1], parts[2]);
        }
        return null; // Invalid format
    }
}