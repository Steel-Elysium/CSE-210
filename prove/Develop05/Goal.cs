namespace Develop05{
public class Goal{
    private string _nameOfGoal, _description;
    private bool _completed;
    private int _pointValue;
    // Constuctors
    public Goal(){
        _completed = false;
        _pointValue = 10;
    }
    public Goal(string name){
        _completed = false;
        _nameOfGoal = name;
    }
    public Goal(string name, string discription){
        _completed = false;
        _nameOfGoal = name;
        _description = discription;
    }
    public Goal(string name, int points){
        _completed = false;
        _nameOfGoal = name;
        _pointValue = points;
    }
    public Goal(string name, int points, bool completed){
        _completed = completed;
        _description = "";
        _nameOfGoal = name;
        _pointValue = points;
    }
    public Goal(string name, string discription, int points){
        _completed = false;
        _description = discription;
        _nameOfGoal = name;
        _pointValue = points;
    }
    public Goal(string name, bool completed){
        _nameOfGoal = name;
        _completed = completed;
        _pointValue = 10;
        _description = "";
    }
    public Goal(string name, string discription, bool completed){
        _completed = completed;
        _nameOfGoal = name;
        _description = discription;
        _pointValue = 10;
    }
    public Goal(string name, string discription, int points, bool completed){
        _completed = completed;
        _description = discription;
        _nameOfGoal = name;
        _pointValue = points;
    }
    // Methods
    public virtual void RecordProgress(){
        this.MarkCompleted();
    }
    public int SetPoints(int points){
        int oldpoints = _pointValue;
        _pointValue = points;
        return oldpoints;
    }
    public string SetDiscription(string discription){
        string oldDiscription = _description;
        _description = discription;
        return oldDiscription;
    }
    public string GetName(){
        return _nameOfGoal;
    }
    protected string GetDiscription(){
        return _description;
    }
    public bool IsCompleted(){
        return _completed;
    }
    public void MarkCompleted(){
        _completed = true;
    }
    public void MarkUncompleted(){
        _completed = false;
    } 
    public virtual int GetCompletionPoints(){
        if(!_completed){
            return _pointValue;
        }
        return 0;
    }
    public virtual int GetTotalCompletionPoints(){
        if(_completed){
            return _pointValue;
        }
        else{
            return 0;
        }
    } 
    public virtual string Display(){
        string responce = "";
        if(_completed){
            responce += "[X]";
        }
        else{
            responce += "[ ]";
        }
        responce += $": {_nameOfGoal} ({this._description})";
        return responce;
    }
    public virtual string GetSaveData(){
        return $"Goal: {this._nameOfGoal}, {this._description}, {this._pointValue}, {this._completed}";
    }
}
}