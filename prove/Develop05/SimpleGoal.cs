using System;

public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points, bool isComplete = false)
        : base(name, description, points)
    {
        _isComplete = isComplete;
    }

    public override int RecordEvent()
    {
        if (_isComplete)
            return 0;

        _isComplete = true;
        return GetPoints();
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStatus()
    {
        string mark = _isComplete ? "X" : " ";
        return $"[{mark}] {GetName()} ({GetDescription()})";
    }

    public override string GetSaveData()
    {
        return $"Simple|{GetName()}|{GetDescription()}|{GetPoints()}|{_isComplete}";
    }
}
