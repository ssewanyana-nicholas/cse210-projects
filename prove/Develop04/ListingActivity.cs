class ListingActivity : MindfulnessActivity
{
    private string[] prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public override void SetDuration(int duration)
    {
        this.duration = duration;
    }

    public void StartActivity()
    {
        description = "This activity will help you reflect on the good things in your life by listing items in a certain area.";
        ShowStartingMessage(description);

        int itemsCount = 0;
        int originalDuration = duration;
        int elapsedTime = 0;

        while (elapsedTime < originalDuration)
        {
            Console.WriteLine("List as many responses to the following prompt:");

            string prompt = prompts[new Random().Next(prompts.Length)];
            Console.WriteLine(prompt);
            Console.WriteLine();
            Console.Write("You may begin in ");
            ShowCountdown(5);

            int numberOfItems = InputList();
            itemsCount += numberOfItems;
            elapsedTime += numberOfItems;

            if (elapsedTime >= originalDuration)
            {
                Console.WriteLine($"\nYou listed {itemsCount} items.");
                ShowEndingMessage();
                break;
            }
        }

        if (elapsedTime < originalDuration)
        {
            Console.WriteLine("Well done!");
            ShowSpinner(3);
        }
    }

    private void ShowCountdown(int seconds)
    {
        for (int count = seconds; count > 0; count--)
        {
            Console.Write(count);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    private int InputList()
    {
        int count = 0;

        while (true)
        {
            Console.Write(">> ");
            Console.ReadLine();
            count++;

            if (count >= duration) {
                break;
            }
        }
        return count;
    }
}
