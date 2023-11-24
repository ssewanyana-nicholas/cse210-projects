public class Program
{
    private List<Goal> goals;
    private int totalScore;

    public Program()
    {
        goals = new List<Goal>();
        totalScore = 0;
    }



    public void CreateGoal()
    {
        Console.WriteLine("\nThe types of goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        Console.Write("Which type of the Goal would you like to create? ");
        int choice = int.Parse(Console.ReadLine());

        Console.Write("What is the name of your Goal? ");
        string name = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        string explain = Console.ReadLine();

        Console.Write("What is the amount of points associated with this Goal? ");
        int baseValue = int.Parse(Console.ReadLine());

        Goal newGoal;

        switch (choice)
        {
            case 1:
                newGoal = new SimpleGoal(name, explain, baseValue);
                break;
            case 2:
                newGoal = new EternalGoal(name, explain, baseValue);
                break;
            case 3:
                Console.Write("How many times does this Goal need to be accomplished for a bonus? ");
                int requiredCount = int.Parse(Console.ReadLine());

                Console.Write("What is the bonus for accomplishing it that many times? ");
                int bonusValue = int.Parse(Console.ReadLine());


                newGoal = new ChecklistGoal(name, explain, baseValue, bonusValue, requiredCount);


                break;
            default:
                Console.WriteLine("Invalid choice. The goal has not been created.");
                return;
        }

        goals.Add(newGoal);
        Console.WriteLine($"New goal '{name}' created successfully!");
    }

    
    public void SaveGoals()
    {
        Console.Write("Enter the filename to save goals: ");
        string filename = Console.ReadLine();

        try
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
             
                writer.WriteLine(totalScore);

              
                foreach (var goal in goals)
                {
                    
                    string completionStatus = (goal is SimpleGoal || goal is ChecklistGoal) ? goal.IsComplete().ToString().ToLower() : "";
                    writer.WriteLine($"{goal.ToFileString()}|{completionStatus}");
                }
            }

            Console.WriteLine("Goals saved successfully!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving goals: {ex.Message}");
        }
    }


    public void LoadGoals()
    {
        Console.Write("Enter the filename to load goals: ");
        string filename = Console.ReadLine();

        try
        {
            goals.Clear();

            using (StreamReader reader = new StreamReader(filename))
            {
                totalScore = int.Parse(reader.ReadLine());

                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    
                    string[] parts = line.Split('|');

                    
                    Goal goal = Goal.FromFileString(line);

                
                    if ((goal is SimpleGoal || goal is ChecklistGoal) && parts.Length > 1)
                    {
                        bool isComplete;

                        
                        if (bool.TryParse(parts.Last(), out isComplete))
                        {
                        
                            goal.SetCompletionStatus(isComplete);
                        }
                        else
                        {
                            Console.WriteLine($"Warning: Unable to parse completion status for goal '{goal?.GetName()}'.");
                        }
                    }

                
                    goals.Add(goal);
                }
            }

            Console.WriteLine("Goals loaded successfully!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading goals: {ex.Message}");
        }
    }




    public void DisplayGoals()
    {
        Console.WriteLine("\nYour Current Goals are:");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.Write($"{i + 1}. ");
            goals[i].DisplayProgress();
        }
    }

    public void RecordEvent()
    {
        Console.WriteLine("\nThe Goals are:");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].GetName()}");
        }

        Console.Write("\nWhich goal did you accomplish? ");
        if (int.TryParse(Console.ReadLine(), out int goalNumber) && goalNumber >= 1 && goalNumber <= goals.Count)
        {
            totalScore += goals[goalNumber - 1].RecordEvent();
            Console.WriteLine($"You now have {totalScore} points");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid goal number.");
        }
    }

    public void Main()
    {
        while (true)
        {
            Console.WriteLine();
            Console.WriteLine($"You have {totalScore} points");
            Console.WriteLine();
            Console.WriteLine("Menu Options");
            Console.WriteLine("\n1. Create a New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");

            Console.Write("Select a choice from the menu: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    CreateGoal();
                    break;
                case 2:
                    DisplayGoals();
                    break;
                case 3:
                    SaveGoals();
                    break;
                case 4:
                    LoadGoals();
                    break;
                case 5:
                    RecordEvent();
                    break;
                case 6:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}

class EntryPoint
{
    static void Main()
    {
        Program program = new Program();
        program.Main();
    }
}


//if a class is already complete the program will not add again the finished goal instead it will inform you that the goal is aleady complete
// as an exceeding requirement