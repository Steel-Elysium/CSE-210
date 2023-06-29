namespace Develop05{
abstract class Goal{
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
    public Goal(int points, string name){
        _completed = false;
        _nameOfGoal = name;
        _pointValue = points;
    }
    public Goal(int points, string name, string discription){
        _completed = false;
        _description = discription;
        _nameOfGoal = name;
        _pointValue = points;
    }

    public abstract void RecordProgress();
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

    public int Getpoints(){
        return _pointValue;
    }
    public void MarkCompleted(){
        _completed = true;
    }
    public void MarkUncompleted(){
        _completed = false;
    } 
    public virtual string Display(){
        string responce = "";
        responce += _nameOfGoal + "";
        if(_completed){
            responce += " is Completed\n";
        }
        else{
            responce += " is not Completed\n";
        }
        responce += $"{this._description}\nThe Point Value is {this._pointValue}";
        return responce;
    }
}
}