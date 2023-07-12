namespace Starfinder{
class Race : Attribute{
    private string _name;
    public Race() : base(){
        _name = "NULL";
    }
    public Race(string name) : base(){
        _name = name;
    }
    public Race(string name, int bonusHealth) : base(bonusHealth){
        _name = name;
    }
    public void AddStat(string name, int modifier){
        base.AddModifier(name, modifier);
    }
    public override void LevelUp(int currentLevel){
        throw new System.NotImplementedException();
    }

}
}