public class CheckListGoal : Goal
{
    private int _amountCompleted = 0;
    private int _target = 0;
    private int _bonus = 0;
    public CheckListGoal(string name, string description, string points, int bonus, int target) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
    }
    public override void RecordEvent()
    {
        _amountCompleted++;
        
    }
    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }
    public override string GetDetailsString()
    {
        if (IsComplete())
        {
            return $"[x] {_name} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
        }
        else
        {
            return $"[ ] {_name} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
        }
    }
    public override string GetStringRepresentation()
    {
        return $"CheckListGoal:{_name},{_description},{_points},{_bonus},{_target},{_amountCompleted}";
    }
}