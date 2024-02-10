using System.Collections;
using System.IO;
public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        int userChoice = 0;

        while (userChoice != 6)
        {
            DisplayPlayerInfo();
            Console.WriteLine();
            Console.WriteLine("Menu Options: ");
            Console.WriteLine();

            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.WriteLine();
            Console.Write("Select a choice from the menu: ");

            userChoice = int.Parse(Console.ReadLine());

            switch (userChoice)
                {
                    case 1 :
                        CreateGoal();
                        break;
                    case 2 :
                        ListGoalDetails();
                        break;
                    case 3 :
                        SaveGoals();
                        break;
                    case 4 :
                        LoadGoals();
                        break;
                    case 5 :
                        RecordEvent();
                        break;
                    default:
                        break;
                }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine();
        Console.WriteLine($"You have {_score} points!");
    }

    public void ListGoals()
    {
        Console.WriteLine();
        Console.WriteLine("The types of Goals are: ");
        Console.WriteLine();
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
    }

    public void ListGoalDetails()
    {
        Console.WriteLine();
        Console.WriteLine("Your current list of goals are:");
        Console.WriteLine();
        for (int i = 0; i < _goals.Count; i++ )
        {
            if (_goals[i].IsComplete())
            {
                Console.WriteLine($"{i + 1}. [V] {_goals[i].GetDetailsString()}");
            }
            else
            {
                Console.WriteLine($"{i + 1}. [ ] {_goals[i].GetDetailsString()}");
            }
        }
    }

    public void CreateGoal()
    {
        ListGoals();

        Console.Write("Which type of goal would you like to create? ");

        int userChoice = int.Parse(Console.ReadLine());

        Console.Write("What is name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What are amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        switch (userChoice)
            {
                case 1 :
                    SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
                    _goals.Add(simpleGoal);
                    break;
                case 2 :
                    EternalGoal eternalGoal = new EternalGoal(name, description, points);
                    _goals.Add(eternalGoal);
                    break;
                case 3 :
                    Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                    int target = int.Parse(Console.ReadLine());
                    Console.Write("What is the bonus for accomplishing it that many times? ");
                    int bonus = int.Parse(Console.ReadLine());
                    ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, target, bonus);
                    _goals.Add(checklistGoal);
                    break;
                default:
                    break;
            }

    }

    public void RecordEvent()
    {
        int index = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{index}. {goal.GetShortName()}");
            index++;
        }

        Console.Write("Which Goal you have accomplished? ");
        int userChoice = int.Parse(Console.ReadLine());

        switch (userChoice)
        {
            case 1:
                Goal simpleGoal = _goals[0];
                simpleGoal.RecordEvent();
                _score += simpleGoal.GetPoints();
                break;
            case 2:
                Goal eternalGoal = _goals[1];
                eternalGoal.RecordEvent();
                _score += eternalGoal.GetPoints();
                break;
            case 3:
                Goal checklistGoal = _goals[2];
                checklistGoal.RecordEvent();
                _score += checklistGoal.GetPoints();
                break;
        }
    }

    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);

            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals()
    {   
        string type;
        string shortName;
        string description;
        int points;
        bool isComplete;
        int amountCompleted;
        int target;
        int bonus;

        Console.WriteLine("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(filename);

        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split("_");

            type = parts[0];
            shortName = parts[1];
            description = parts[2];
            points = int.Parse(parts[3]);

            switch(type)
            {
                case "Simple":
                    isComplete = bool.Parse(parts[4]);
                    SimpleGoal simpleGoal = new SimpleGoal (shortName, description, points, isComplete);
                    _goals.Add(simpleGoal);
                    break;
                case "Eternal":
                    EternalGoal eternalGoal = new EternalGoal (shortName, description, points);
                    _goals.Add(eternalGoal);
                    break;
                case "Checklist":
                    amountCompleted = int.Parse(parts[4]);
                    target = int.Parse(parts[5]);
                    bonus = int.Parse(parts[6]);
                    ChecklistGoal checklistGoal = new ChecklistGoal (shortName, description, points, amountCompleted, target, bonus);
                    _goals.Add(checklistGoal);
                    break;
            }
        }
    }
}