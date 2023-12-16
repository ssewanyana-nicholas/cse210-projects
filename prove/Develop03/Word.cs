class Word
{
    private string Text { get; set; }
    public bool Hidden { get; private set; }

    public Word(string text)
    {
        Text = text;
        Hidden = false;
    }

    public void Hide()
    {
        Hidden = true;
    }

    public string Display()
    {
        return Hidden ? new string('_', Text.Length) : Text;
    }

    public string GetText()
    {
        return Text;
    }
}