namespace Develop05{
public class Eternal : Goal{
    private int _timesComplted;
    public Eternal() : base(){
        _timesComplted = 0;
    }
    public Eternal(string name) : base(name){
        _timesComplted = 0;
    }
    public Eternal(string name, int points) : base(name, points){
        _timesComplted = 0;
    }
    public Eternal(string name, string discription) : base(name, discription){
        _timesComplted = 0;
    }
    public Eternal(string name, string discription, int points) : base(name, discription, points){
        _timesComplted = 0;
    }
    public Eternal(string name, string discription, int points, int timesCompleted) : base(name, discription, points){
        _timesComplted = timesCompleted;
    }
    public override void RecordProgress(){
        _timesComplted++;
    }
    public override string Display(){
        return $"[ ]: {base.GetName()} ({base.GetDiscription()})";
    }
    public override string GetSaveData(){
        return $"Eternal: {base.GetName()}, {base.GetDiscription()}, {base.GetCompletionPoints()}, {this._timesComplted}";
    }
    public override int GetTotalCompletionPoints(){
        return _timesComplted * base.GetCompletionPoints();
    }
    
}
}