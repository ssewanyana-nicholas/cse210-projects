public class ChecklistGoal : Goal
{
    private int requiredCount;
    private int bonusValue;
    private int completedCount;

    public ChecklistGoal(string name, string explain, int baseValue, int requiredCount, int bonusValue)
        : base(name, explain, baseValue)
    {
        this.requiredCount = requiredCount;
        this.bonusValue = bonusValue;
        this.completedCount = 0;
    }

    public override int RecordEvent()
    {
        if (IsComplete())
        {
            Console.WriteLine($"You already completed the {GetName()} goal.");
            return 0;
        }

        completedCount++;

        if (completedCount < requiredCount)
        {

            currentValue += baseValue;

            Console.WriteLine($"Recorded progress on the {GetName()} goal ({completedCount}/{requiredCount} times) and earned {baseValue} points.");

            return baseValue;

        }
        else
        {
            currentValue += bonusValue;
            Console.WriteLine($"Congratulations! You completed the {GetName()} goal {completedCount}/{requiredCount} times and earned a bonus of {bonusValue} points.");

            return baseValue + bonusValue;
        }

    }

    public override bool IsComplete()
    {
        return completedCount == requiredCount;
    }

    internal override string ToFileString()
    {
        return $"{nameof(ChecklistGoal)}|{name}|{explain}|{baseValue}|{bonusValue}|{requiredCount}|{completedCount}";
    }

    public override void DisplayProgress()
    {
        Console.WriteLine($"[{(IsComplete() ? "X" : " ")}] {GetName()} ({explain}) -- Currently completed: {completedCount}/{requiredCount}");
    }

    internal override void SetCompletionStatus(bool isComplete)
    {
        completedCount = isComplete ? requiredCount : 0;
    }


}
