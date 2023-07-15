namespace Starfinder {
class Stat {
    private int _stat, _modifier;
    private string _name;
    public Stat(){
        _stat = 10;
        _modifier = 0;
        _name = "";
    }
    public Stat(string name){
        _stat = 10;
        _modifier = 0;
        _name = name;
    }
    public Stat(int stat){
        _stat = stat;
        _modifier = (_stat / 2) - 5; // The modifier is the the (stat base / 2) - 5 
        _name = "";
    }
    public Stat(int stat, string name){
        _stat = stat;
        _modifier = (_stat / 2) - 5;
        _name = name;
    }
    public virtual int GetModifier(){
        return _modifier;
    }
    public virtual void EditStat(int newStat, bool setBaseStat = false){
        _stat = newStat;
        _modifier = _stat / 2 - 5;
    }
    public string GetName(){
        return _name;
    }
    public virtual int GetStat(){
        return _stat;
    }
    public void AddStat(int statAddition){
        _stat += statAddition;
        _modifier = _stat / 2 - 5;
    }
}
}