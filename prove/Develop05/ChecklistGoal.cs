using System;

public class ChecklistGoal : Goal
{
    private int _target;
    private int _bonus;
    private int _current;

    public ChecklistGoal(string name, string description, int points,
                         int target, int bonus, int current = 0)
        : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _current = current;
    }

    public override int RecordEvent()
    {
        if (_current >= _target)
            return 0;

        _current++;

        if (_current == _target)
            return GetPoints() + _bonus;

        return GetPoints();
    }

    public override bool IsComplete()
    {
        return _current >= _target;
    }

    public override string GetStatus()
    {
        string mark = IsComplete() ? "X" : " ";
        return $"[{mark}] {GetName()} -- Completed {_current}/{_target} times";
    }

    public override string GetSaveData()
    {
        return $"Checklist|{GetName()}|{GetDescription()}|{GetPoints()}|{_target}|{_bonus}|{_current}";
    }
}
