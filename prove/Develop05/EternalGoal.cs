public class EternalGoal : Goal
{
    public EternalGoal(string name, string explain, int baseValue) : base(name, explain, baseValue)
    {
    }

    public override int RecordEvent()
    {
        currentValue += baseValue;
        Console.WriteLine($"You recorded progress on the eternal goal '{name}' and earned {baseValue} points.");
        return baseValue;
    }

    internal override void SetCompletionStatus(bool isComplete)
    {
       
        currentValue = isComplete ? baseValue : 0;
    }

    public override bool IsComplete()
    {
        return false;
    }

    internal override string ToFileString()
    {
        return $"{nameof(EternalGoal)}|{name}|{explain}|{baseValue}";
    }

    public override string GetName()
    {
        return name;
    }
}
