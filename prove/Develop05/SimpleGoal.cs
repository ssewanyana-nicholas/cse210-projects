
public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string explain, int baseValue) : base(name, explain, baseValue)
    {
    }

    public override int RecordEvent()
    {
        if (IsComplete())
        {
            Console.WriteLine($"You already completed the {GetName()} goal.");
            return 0;
        }

        currentValue = baseValue;
        Console.WriteLine($"Congratulations! You have earned {currentValue} points!");
        return currentValue;
    }

    internal override void SetCompletionStatus(bool isComplete)
    {
    
        currentValue = isComplete ? baseValue : 0;
    }

    public override bool IsComplete()
    {
        return currentValue >= baseValue;
    }

    internal override string ToFileString()
    {
        return $"{nameof(SimpleGoal)}|{name}|{explain}|{baseValue}";
    }


    public override string GetName()
    {
        return name;
    }


}

