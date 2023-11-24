public abstract class Goal
{
    protected string name;
    protected string explain;
    protected int baseValue;
    protected int currentValue;
    protected bool isComplete;

    public Goal(string name, string explain, int baseValue)
    {
        this.name = name;
        this.explain = explain;
        this.baseValue = baseValue;
        this.currentValue = 0;
    }

    public virtual string GetName()
    {
        return name;
    }

    internal abstract void SetCompletionStatus(bool isComplete);

    public abstract int RecordEvent();
    public abstract bool IsComplete();

    public virtual void DisplayProgress()
    {
        Console.WriteLine($"[{(IsComplete() ? "X" : " ")}] {name} ({explain})");
    }

    internal virtual string ToFileString()
    {
        
        return $"{name}|{explain}|{baseValue}";
    }

    internal static Goal  FromFileString(string line)
    {
        string[] parts = line.Split('|');
        string type = parts[0];
        string name = parts[1];
        string explain = parts[2];
        int baseValue = int.Parse(parts[3]);

        switch (type)
        {
            case nameof(SimpleGoal):
                return new SimpleGoal(name, explain, baseValue);
            case nameof(EternalGoal):
                return new EternalGoal(name, explain, baseValue);
            case nameof(ChecklistGoal):
                int requiredCount = int.Parse(parts[4]);
                int bonusValue = int.Parse(parts[5]);
                int completedCount = int.Parse(parts[6]);

                return new ChecklistGoal(name, explain, baseValue, bonusValue, requiredCount);
            default:
                throw new ArgumentException($"Invalid goal type: {type}");
        }
    }


}