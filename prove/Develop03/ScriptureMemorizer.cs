class ScriptureMemorizer
{
    private Scripture scripture;
    private List<Word> words;

    public bool AllWordsHidden => words.All(w => w.Hidden);

    public ScriptureMemorizer(Scripture scripture)
    {
        this.scripture = scripture;
        this.words = scripture.GetText().Split(' ').Select(word => new Word(word)).ToList();
    }

    public string GetFullScripture()
    {
        return $"{scripture.Reference} {string.Join(" ", words.Select(w => w.GetText()))}";
    }

    public string GetHiddenScripture()
    {
        return $"{scripture.Reference} {string.Join(" ", words.Select(w => w.Display()))}";
    }

    public void HideRandomWord(Random random)
    {
        var visibleWords = words.Where(w => !w.Hidden).ToList();
        if (visibleWords.Count == 0)
        {
            // No words left to hide
            return;
        }

        int randomIndex = random.Next(visibleWords.Count);
        visibleWords[randomIndex].Hide();
    }
}