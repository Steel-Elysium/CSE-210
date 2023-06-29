namespace Develop05{
public class Checklist : Goal{
    private int _timesNeededToComplete;
    private int _timesCompleted;
    private int _pointsWhenCompleted;
    public Checklist():base(){
        _timesNeededToComplete = 5;
        _timesCompleted = 0;
        _pointsWhenCompleted = 100;
    }
    public Checklist(string name) : base(name){
        _timesNeededToComplete = 5;
        _timesCompleted = 0;
        _pointsWhenCompleted = 100;
    }
    public Checklist(string name, bool completed) : base(name, completed){
        _timesNeededToComplete = 5;
        _pointsWhenCompleted = 100;
        if(completed){
            _timesCompleted = 5;
        }
        else{
            _timesCompleted = 0;
        }
    }
    public Checklist(string name, string discription) : base(name, discription){
        _timesNeededToComplete = 5;
        _timesCompleted = 0;
        _pointsWhenCompleted = 100;
    }
    public Checklist(string name, string discription, bool completed) : base(name, discription, completed){
        _timesNeededToComplete = 5;
        _pointsWhenCompleted = 100;
        if(completed){
            _timesCompleted = 5;
        }
        else{
            _timesCompleted = 0;
        }
    }
    public Checklist(string name, int points) : base(name, points){
        _timesNeededToComplete = 5;
        _timesCompleted = 0;
        _pointsWhenCompleted = 100;
    }
    public Checklist(string name, int points, bool completed) : base(name, points, completed){
        _timesNeededToComplete = 5;
        _pointsWhenCompleted = 100;
        if(completed){
            _timesCompleted = 5;
        }
        else{
            _timesCompleted = 0;
        }
    }
    public Checklist(string name, string discription, int points) : base(name, discription, points){
        _timesNeededToComplete = 5;
        _timesCompleted = 0;
        _pointsWhenCompleted = 100;
    }
    public Checklist(string name, string discription, int points, bool completed) : base(name, discription, points, completed){
        _timesNeededToComplete = 5;
        _pointsWhenCompleted = 100;
        if(completed){
            _timesCompleted = 5;
        }
        else{
            _timesCompleted = 0;
        }
    }
    public Checklist(string name, int points, int neededCompletions) : base(name, points){
        _timesNeededToComplete = neededCompletions;
        _timesCompleted = 0;
        _pointsWhenCompleted = 100;
    }
    public Checklist(string name, int points, bool completed, int neededCompletions) : base(name, points, completed){
        _timesNeededToComplete = neededCompletions;
        _pointsWhenCompleted = 100;
        if(completed){
            _timesCompleted = neededCompletions;
        }
        else{
            _timesCompleted = 0;
        }
    }
    public Checklist(string name, string discription, int points, int neededCompletions) : base(name, discription, points){
        _timesNeededToComplete = neededCompletions;
        _timesCompleted = 0;
        _pointsWhenCompleted = 100;
    }
    public Checklist(string name, string discription, int points, bool completed, int neededCompletions) : base(name, discription, points, completed){
        _timesNeededToComplete = neededCompletions;
        _pointsWhenCompleted = 100;
        if(completed){
            _timesCompleted = neededCompletions;
        }
        else{
            _timesCompleted = 0;
        }
    }
    public Checklist(string name, int points, int neededCompletions, int completedPoints) : base(name, points){
        _pointsWhenCompleted = completedPoints;
        _timesCompleted = 0;
        _timesNeededToComplete = neededCompletions;
    }
    public Checklist(string name, int points, bool completed, int neededCompletions, int completedPoints) : base(name, points, completed){
        _timesNeededToComplete = neededCompletions;
        _pointsWhenCompleted = completedPoints;
        if(completed){
            _timesCompleted = neededCompletions;
        }
        else{
            _timesCompleted = 0;
        }
    }
    public Checklist(string name, string discription, int points, int neededCompletions, int completedPoints) : base(name, discription, points){
        _timesNeededToComplete = neededCompletions;
        _timesCompleted = 0;
        _pointsWhenCompleted = completedPoints;
    }
    public Checklist(string name, string discription, int points, bool completed, int neededCompletions, int completedPoints) : base(name, discription, points, completed){
        _timesNeededToComplete = neededCompletions;
        _pointsWhenCompleted = completedPoints;
        if(completed){
            _timesCompleted = neededCompletions;
        }
        else{
            _timesCompleted = 0;
        }
    }
    public Checklist(string name, string discription, int points, bool completed, int neededCompletions, int completedPoints, int timesCompleted) : base(name, discription, points, completed){
        _pointsWhenCompleted = completedPoints;
        _timesCompleted = timesCompleted;
        _timesNeededToComplete = neededCompletions;
        if(_timesCompleted == _timesNeededToComplete){
            base.MarkCompleted();
        }
    }
    public int GetTimesCompleted(){
        return _timesCompleted;
    }
    public override void RecordProgress(){
        if(base.IsCompleted()){
            _timesCompleted++;
            if(_timesCompleted == _timesNeededToComplete){
                base.MarkCompleted();   
            }
        }
    }
    public override int GetCompletionPoints(){
        int points = base.GetCompletionPoints();
        if(_timesCompleted + 1 == _pointsWhenCompleted){
            points += _pointsWhenCompleted;
        }
        return points;
    }
    public override string Display(){
        string responce = base.Display();
        responce += $" -- Curently Completed: {this._timesCompleted}/{this._timesNeededToComplete}";
        return responce;
    }
    public override string GetSaveData(){
        return $"Checklist: {base.GetName()}, {base.GetDiscription()}, {base.GetCompletionPoints()}, {base.IsCompleted()}, {this._timesNeededToComplete}, {this._pointsWhenCompleted}, {this._timesCompleted}";
    }
    public override int GetTotalCompletionPoints(){
        int points = base.GetCompletionPoints() * _timesCompleted;
        if(base.IsCompleted()){
            points += _pointsWhenCompleted;
        }
        return points;
    }
}
}