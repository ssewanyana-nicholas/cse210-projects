class ScriptureMemorizer
{
    private Scripture scripture;
    private List<Word> words;

    public bool AllWordsHidden => words.All(w => w.Hidden);

    public ScriptureMemorizer(Scripture scripture)
    {
        this.scripture = scripture;
        this.words = scripture.Text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public string GetFullScripture()
    {
        return $"{scripture.Reference} {string.Join(" ", words.Select(w => w.Text))}";
    }

    public string GetHiddenScripture()
    {
        return $"{scripture.Reference} {string.Join(" ", words.Select(w => w.Hidden ? "_____" : w.Text))}";
    }

    public void HideRandomWord(Random random)
    {
        int visibleWords = words.Count(w => !w.Hidden);
        if (visibleWords == 0)
        {
            // No words left to hide
            return;
        }

        int randomIndex = random.Next(visibleWords);
        int countHidden = 0;

        for (int i = 0; i < words.Count; i++)
        {
            if (!words[i].Hidden)
            {
                if (countHidden == randomIndex)
                {
                    words[i].Hide();
                    break;
                }
                countHidden++;
            }
        }
    }
}