class MindfulnessActivity
{
    protected int duration;
    protected string description;

    public virtual void SetDuration(int duration)
    {
        this.duration = duration;
    }

    public void ShowStartingMessage(string description)
    {
        Console.WriteLine($"\nWelcome to the {this.GetType().Name}");
        Console.WriteLine();
        Console.WriteLine(description);
        Console.WriteLine();
        AskForDuration();
        Console.Clear();

        Console.WriteLine("Get ready...");
        ShowSpinner(3);
        Console.WriteLine();
    }

    public void ShowEndingMessage()
    {
        Console.WriteLine("Well done!");
        ShowSpinner(3);
        Console.WriteLine($"\nYou have completed another {duration} seconds of the {this.GetType().Name}");
        ShowSpinner(3);
        Console.WriteLine();
    }

    protected void ShowSpinner(int seconds)
    {
        List<string> animationStrings = new List<string> { "|", "/", "-", "\\" };

        for (int i = 0; i < seconds * 10; i++)
        {
            Console.Write(animationStrings[i % animationStrings.Count]);
            Thread.Sleep(150);
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
        }
    }

    protected void AskForDuration()
    {
        Console.Write("How long, in seconds, would you like for your session? ");
        int duration = Convert.ToInt32(Console.ReadLine());
        SetDuration(duration);
    }
}