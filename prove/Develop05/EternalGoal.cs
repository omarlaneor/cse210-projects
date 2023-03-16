public class EternalGoal: Goal {

    public EternalGoal(): base(){
        _type = MenuGoals.EternalGoal;
    }

    public EternalGoal(string title, string description, int points, bool completedGoal): base(title, description, points, completedGoal){
        _type = MenuGoals.EternalGoal;
    }

    public override int RecordEvent(){
        _goalCompleted = Completed();
        return _points;
    }

    public override bool Completed(){
        return false;
    }
}