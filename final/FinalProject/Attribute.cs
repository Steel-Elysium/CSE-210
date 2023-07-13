using System.Collections.Generic;
namespace Starfinder {
abstract class Attribute {
    public struct StatModifier{
        public int statBonus;
        public string statName;
    }
    private int _bonusHealth;
    private string _name;
    private List<StatModifier> _statBonuses;
    public Attribute(){
        _name = "NULL";
        _bonusHealth = 0;
        _statBonuses = new List<StatModifier>();
    }
    public Attribute(int health){
        _name = "NULL";
        _bonusHealth = health;
        _statBonuses = new List<StatModifier>();
    }
    public Attribute(string name){
        _name = name;
        _bonusHealth = 0;
        _statBonuses = new List<StatModifier>();
    }
    public Attribute(string name, int health){
        _statBonuses = new List<StatModifier>();
        _name = name;
        _bonusHealth = health;
    }
    public virtual int GetHealth(){
        return _bonusHealth;
    }
    public abstract void LevelUp(int currentLevel);
    public abstract void StartUp(List<Stat> startingStats);
    public void AddModifier(string name, int mod){
        StatModifier stat;
        stat.statName = name;
        stat.statBonus = mod;
        _statBonuses.Add(stat);
    }
    public StatModifier GetModifier(int index){
        if(_statBonuses.Count == 0){
            StatModifier stat;
            stat.statBonus = 0;
            stat.statName = "NULL";
            return stat;
        }
        return _statBonuses[index];
    }
    public List<StatModifier> GetModifiers(){
        return _statBonuses;
    }
    public string GetName(){
        return _name;
    }
}
}