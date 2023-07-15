namespace Starfinder {
class Skill : Stat {
    private int _classTraining, _skillMod;
    public Skill() : base(){
        _classTraining = 0;
        SetSkillMod();
    }
    public Skill(string name) : base(name){
        _classTraining = 0;
        SetSkillMod();
    }
    public Skill(int amountTrained) : base(){
        _classTraining = amountTrained;
        SetSkillMod();
    }
    public Skill(string name, int amountTrained) : base(name){
        _classTraining = amountTrained;
        SetSkillMod();
    }
    public Skill(int amountTrained, int statAmount) : base(statAmount){
        _classTraining = amountTrained;
        SetSkillMod();
    }
    public Skill(string name, int amountTrained, int statAmount) : base(statAmount, name){
        _classTraining = amountTrained;
        SetSkillMod();
    }
    private void SetSkillMod(){
        _skillMod = base.GetModifier() + _classTraining;
    }
    public override int GetModifier(){
        return _skillMod;
    }
    public override int GetStat(){
        return -99999;
    }
    public override void EditStat(int newStat, bool setBaseStat = false){
        if(!setBaseStat){
            _classTraining += newStat;
            SetSkillMod();
        }else{
            base.EditStat(newStat);
        }
    }
    
}
}