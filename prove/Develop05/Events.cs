using System.Text;

public class Events{
    private int _totalPoints{get; set;} = 0;
    private Dictionary<int, Goal> _goalDictionary = new Dictionary<int, Goal>();

    public void DisplayList()
    {
        Console.WriteLine("Your goals are the following: ");
            for (int i = 1; i <= _goalDictionary.Count(); i++){
                Console.Write($"{i}. {IsAchievedDisplay(_goalDictionary[i]._goalCompleted)} {_goalDictionary[i]._goalTitle} ({_goalDictionary[i]._goalDescription})");
                if(_goalDictionary[i] is ChecklistGoal checklistGoal)
                {
                    Console.Write($"-- Currently Completed: {checklistGoal._timesCompleted}/{checklistGoal._counterTimes}");
                }
        }
        Console.WriteLine();
        Console.WriteLine($"You have {_totalPoints} points");
    }

    private string IsAchievedDisplay(bool isComplete){
        if(isComplete){
            return "[X]";
        }
        return "[ ]";
    }

    public int GetListNumber() {
        return _goalDictionary.Count() + 1;
    }

    public void AddGoal(MenuGoals type)
    {
        switch(type){
            case MenuGoals.SimpleGoal:
                _goalDictionary.Add(GetListNumber(), new Goal());
                break;
            case MenuGoals.EternalGoal:
                _goalDictionary.Add(GetListNumber(), new EternalGoal());
                break;
            case MenuGoals.ChecklistGoal:
                _goalDictionary.Add(GetListNumber(), new ChecklistGoal());
                break;    
        }
    }

    public void GetRecordEvent()
    {
        for (int i = 1; i <= _goalDictionary.Count(); i++){
            Console.WriteLine($"{i}. {_goalDictionary[i]._goalTitle}");
        }
        Console.WriteLine("Which goal were you working on?: ");
        string input = Console.ReadLine();
        if (int.TryParse(input, out int goalNumber))
            {
                if(goalNumber <= _goalDictionary.Count()){
                    _totalPoints += _goalDictionary[goalNumber].RecordEvent();
                }
                else{
                    Console.WriteLine("Invalid number entered.");
                }
            }
        else
            {
                Console.WriteLine($"Invalid input.");
            }
    }

      public void Save(string fileName)
    {
        String file = @$"{fileName}";
        StringBuilder goals = new StringBuilder();
        goals.AppendLine(_totalPoints.ToString());
        foreach (KeyValuePair<int, Goal> goal in _goalDictionary)
        {
            String newLine;
            if (goal.Value._type == MenuGoals.ChecklistGoal){
                var checklistGoal = (ChecklistGoal) goal.Value;
                newLine = $"{checklistGoal._type}|{checklistGoal._goalTitle}|{checklistGoal._goalDescription}|{checklistGoal._points}|{checklistGoal._goalCompleted}|{checklistGoal._pointsForBonus}|{checklistGoal._counterTimes}|{checklistGoal._timesCompleted}";
            }
            else{
                newLine = $"{goal.Value._type}|{goal.Value._goalTitle}|{goal.Value._goalDescription}|{goal.Value._points}|{goal.Value._goalCompleted}";
            }
            
            
            goals.AppendLine(newLine);
        }

        try
        {
            File.WriteAllText(file, goals.ToString());
            Console.WriteLine($"Goals saved as {file}");
        }
        catch (Exception)
        {
            Console.WriteLine("Data could not be written to this file.");
            return;
        }
}

    public void Load(string file){
        int type = 0;
        int title = 1;
        int description = 2;
        int pointsForGoal = 3;
        int goalIsAchieved = 4;
        int pointsForBonus = 5;
        int counterTimes = 6;
        int timesCompleted = 7;
        _goalDictionary = new Dictionary<int, Goal>();
        using(var reader = new StreamReader(@$"{file}"))
        {
            _totalPoints = int.Parse(reader.ReadLine());
            while ((!reader.EndOfStream)) {
            var values = reader.ReadLine().Split('|');
            
            if (values[type] == MenuGoals.ChecklistGoal.ToString())
            {
                _goalDictionary.Add(GetListNumber(), new ChecklistGoal(values[title], values[description], int.Parse(values[pointsForGoal]),int.Parse(values[counterTimes]),int.Parse(values[timesCompleted]),int.Parse(values[pointsForBonus]),bool.Parse(values[goalIsAchieved])));
            }
            else if (values[type] == MenuGoals.EternalGoal.ToString()){
                _goalDictionary.Add(GetListNumber(), new EternalGoal(values[title], values[description], int.Parse(values[pointsForGoal]),bool.Parse(values[goalIsAchieved])));
            }
            else if (values[type] == MenuGoals.SimpleGoal.ToString()){
                _goalDictionary.Add(GetListNumber(), new Goal(values[title], values[description], int.Parse(values[pointsForGoal]),bool.Parse(values[goalIsAchieved])));
            }
            }
        }
    } 
}
