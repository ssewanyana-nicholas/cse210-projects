class Scripture
{
    public string Reference { get; private set; }
    private string Text { get; set; }

    public Scripture(string reference, string text)
    {
        Reference = reference;
        Text = text;
    }

    public string GetText()
    {
        return Text;
    }
}
