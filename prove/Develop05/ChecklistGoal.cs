public class ChecklistGoal: Goal {
    public int _counterTimes {get; set;} = 3;

    public int _timesCompleted {get; set;}

    public int _pointsForBonus {get; set;} = 500;

    public ChecklistGoal() : base(){
        _counterTimes = SetCounterTimes();
        _pointsForBonus = SetBonusPoints();
        _type = MenuGoals.ChecklistGoal;
    }

    public ChecklistGoal(string title, string description, int points, int counterTimes, int timesCompleted, int pointsForBonus, bool completedGoal) : base(title, description, points, completedGoal){
        _counterTimes = counterTimes;
        _timesCompleted = timesCompleted;
        _pointsForBonus = pointsForBonus;
        _type = MenuGoals.ChecklistGoal;
    }

    private int SetBonusPoints()
    {
        Console.WriteLine("What bonus will you get for doing it?: ");
        string input = Console.ReadLine();
        if (int.TryParse(input, out int points))
            {
                return points;
            }
        else
            {
                Console.WriteLine($"Invalid input. Set to default {_pointsForBonus}.");
                return _pointsForBonus;
            }
    }

    private int SetCounterTimes()
    {
        Console.WriteLine("How many times will you need to meet this goal to receive the bonus?: ");
        string input = Console.ReadLine();
            if (int.TryParse(input, out int times))
                {
                    return times;
                }
            else
                {
                    Console.WriteLine($"Invalid input. Set to default{_counterTimes}.");
                    return _counterTimes;
                }
    }

    public override int RecordEvent(){
        _timesCompleted++;
        _goalCompleted = Completed();
        if(_goalCompleted){
            return _points + _pointsForBonus;
        }

        return _points;
    }

    public override bool Completed(){
        if(_timesCompleted == _counterTimes)
        {
            return true;
        }
        return false;
    }
}