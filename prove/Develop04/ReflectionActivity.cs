class ReflectionActivity : MindfulnessActivity
{
    private string[] prompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Recall a moment when you faced your fears.",
        "Consider a time when you felt truly inspired.",
    };

    private string[] reflectionQuestions = {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you feel when it was complete?",
        "What did you learn about yourself through this experience?",
    };

    public override void SetDuration(int duration)
    {
        this.duration = duration;
    }

    public void StartActivity()
    {
        description = "This activity will help you reflect on times when you showed strength and resilience. This will help you recognize your power and how you can apply it to other aspects of your life.";
        ShowStartingMessage(description);
        CheckReadyToContinue();
        Console.Write("You may begin in ");
        ShowCountdown(5);
        ShowReflectionPrompts();
    }

    private void CheckReadyToContinue()
    {
        Console.WriteLine("Consider the following prompt:");
        string prompt = prompts[new Random().Next(prompts.Length)];
        Console.WriteLine($"--{prompt}--");
        Console.WriteLine("When you have something in mind, press Enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder each of the following questions as they relate to this experience:");
    }

    private void ShowReflectionPrompts()
    {
        Random random = new Random();

        foreach (string question in reflectionQuestions)
        {
            int randomIndex = random.Next(reflectionQuestions.Length);
            Console.Write(reflectionQuestions[randomIndex]);
            Console.WriteLine();
            ShowSpinner(5);
        }

        int timeLeft = duration - (reflectionQuestions.Length * 3);
        if (timeLeft > 0)
        {
            ShowSpinner(timeLeft);
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