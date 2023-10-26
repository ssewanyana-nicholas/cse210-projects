class ScriptureLibrary
{
    private List<Scripture> scriptures = new List<Scripture>();

    public void AddScripture(string reference, string text)
    {
        scriptures.Add(new Scripture(reference, text));
    }

    public Scripture GetRandomScripture(Random random)
    {
        return scriptures[random.Next(scriptures.Count)];
    }
}