using System.Collections.Generic;
namespace Starfinder{
abstract class Attribute{
    public struct StatModifier{
        public int statBonus;
        public string statName;
    }
    private int _bonusHealth;
    private List<StatModifier> _statBonuses;
    public Attribute(){
        _bonusHealth = 0;
        _statBonuses = new List<StatModifier>();
    }
    public Attribute(int health){
        _bonusHealth = health;
        _statBonuses = new List<StatModifier>();
    }
    public virtual int GetHealth(){
        return _bonusHealth;
    }
    public abstract void LevelUp(int currentLevel);
    public void AddModifier(string name, int mod){
        StatModifier stat;
        stat.statName = name;
        stat.statBonus = mod;
        _statBonuses.Add(stat);
    }
    public virtual StatModifier GetModifier(int index){
        return _statBonuses[index];
    }
    public List<StatModifier> GetModifiers(){
        return _statBonuses;
    }
}
}