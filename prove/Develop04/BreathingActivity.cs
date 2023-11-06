class BreathingActivity : MindfulnessActivity
{
    public override void SetDuration(int duration)
    {
        this.duration = duration;
    }

    public void StartActivity()
    {
        description = "This activity will help you relax by walking you through breathing in\n  and out slowly. Clear your mind and focus on your breathing.";
        ShowStartingMessage(description);
        ShowBreathingMessages();
    }

    private void ShowBreathingMessages()
    {
        for (int i = 0; i < duration; i += 10)
        {
            Console.Write("Breathe in...");
            ShowCountdown(4); 

            Console.Write("Now breathe out...");
            ShowCountdown(6);
            Console.WriteLine();
        }

        ShowEndingMessage();
    }

    private void ShowCountdown(int seconds)
    {
        for (int count = seconds; count > 0; count--)
        {
            Console.Write(count);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine();
    }
}