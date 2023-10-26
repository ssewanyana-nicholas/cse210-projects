class PromptGenerator
{
    private string[] prompts = {
        "What's the most interesting thing that happened today?",
        "Write about a challenge you faced and how you overcame it.",
        "Describe a person who had a positive impact on your day.",
        "What are you grateful for today?",
        "Write about a goal you want to achieve and how you plan to get there."
    };

    private Random random = new Random();

    public string GeneratePrompt()
    {
        int index = random.Next(prompts.Length);
        return prompts[index];
    }
}