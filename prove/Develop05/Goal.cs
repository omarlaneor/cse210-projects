public class Goal {
    public string _goalTitle {get; set;} 
    public string _goalDescription {get; set;}
    public int _points{get; set;} = 50;
    public bool _goalCompleted{get; set;}

    public MenuGoals _type;

    public Goal(){
        _goalTitle = SetTitle();
        _goalDescription = SetDescription();
        _points = SetPoints();
        _type = MenuGoals.SimpleGoal;
    }

    public Goal(string title, string description, int points, bool completedGoal){
        _goalTitle = title;
        _goalDescription = description;
        _points = points;
        _goalCompleted = completedGoal;
        _type = MenuGoals.SimpleGoal;
    }

    public virtual int RecordEvent(){
        _goalCompleted = Completed();
        return _points;
    }

    public virtual bool Completed(){
        return true;
    }

    public string SetTitle()
    {
        Console.WriteLine("Please, enter a name fot this goal: ");
        return Console.ReadLine();
    }

    public string SetDescription()
    {
        Console.WriteLine("Please, enter a short description of this goal: ");
        return Console.ReadLine();
    }

    public int SetPoints()
    {
    Console.WriteLine("How many points will this be worth?: ");
    string input = Console.ReadLine();
    if (int.TryParse(input, out int points))
        {
            return points;
        }
    else
        {
            Console.WriteLine($"Invalid input. Set to default {_points}. ");
            return _points;
        }
    }
}