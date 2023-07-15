using System.Collections.Generic;

namespace Starfinder {
class PlayerClass : Attribute {
    private static string[] _preselectedClassName = {"Envoy", "Mechanic", "Mystic", "Operative", "Solarian", "Soldier", "Technomancer"};
    private static int[] _preselectedClassHealth = {6, 6, 6, 6, 7, 7, 5}, _preselectedClassProficencyBonus = {8, 4, 6, 8, 4, 4, 4};
    private string[][] _preselectedClassProfisancies = 
    {
        new string[] {"Acrobatics", "Athletics", "Bluff", "Computers", "Culture", "Diplomacy", "Disguise", "Engineering", "Intimidate", "Medicine", "Perception", "Piloting", "Sense Motive", "Sleight of Hand", "Stealth"},
        new string[] {"Athletics", "Computers", "Engineering", "Medicine", "Perception", "Physical Science", "Piloting", "NULL", "NULL", "NULL", "NULL", "NULL", "NULL", "NULL", "NULL"},
        new string[] {"Bluff", "Culture", "Diplomacy", "Disguise", "Intimidate", "Life Science", "Medicine", "Mysticism", "Perception", "Sense Motive", "Survival", "NULL", "NULL", "NULL", "NULL"},
        new string[] {"Acrobatics", "Athletics", "Bluff", "Computers", "Culture", "Disguise", "Engineering", "Intimidate", "Medicine", "Perception", "Piloting", "Sense Motive", "Sleight of Hand", "Stealth", "Survival"},
        new string[] {"Acrobatics", "Athletics", "Diplomacy", "Intimidate", "Mysticism", "Perception", "Physical Science", "Sense Motive", "Stealth", "NULL", "NULL", "NULL", "NULL", "NULL", "NULL"},
        new string[] {"Acrobatics", "Athletics", "Engineering", "Intimidate", "Medicine", "Piloting", "Survival", "NULL", "NULL", "NULL", "NULL", "NULL", "NULL", "NULL", "NULL"},
        new string[] {"Computers", "Engineering", "Life Science", "Mysticism", "Physical Science", "Piloting", "Sleight of Hand", "NULL", "NULL", "NULL", "NULL", "NULL", "NULL", "NULL", "NULL"}
    };
private string[] _profStat;
    private int _staminaBase, _profBonus;
    public PlayerClass() : base(){
        _staminaBase = 0;
    }
    public PlayerClass(string name) : base(name){
        _staminaBase = 0;
    }
    public PlayerClass(string name, int health) : base(name, health){
        _staminaBase = health;
    }
    public PlayerClass(string name, int health, string[] classProf, int profBonus){

    }
    public PlayerClass(int prepickedClass) : base(_preselectedClassName[prepickedClass], _preselectedClassHealth[prepickedClass]){
        _staminaBase = _preselectedClassHealth[prepickedClass];
        _profBonus = _preselectedClassProficencyBonus[prepickedClass];
        _profStat = _preselectedClassProfisancies[prepickedClass];

    }
    public int GetStaminaBase(){
        return _staminaBase;
    }
    public override void LevelUp(int currentLevel){
        throw new System.NotImplementedException();
    }
    public override void StartUp(List<Stat> startingStats){
        foreach(Stat curStat in startingStats){
            foreach(string statName in _profStat){
                if(statName == "NULL"){
                    break;
                }
                if(statName == curStat.GetName()){
                    curStat.EditStat(_profBonus);
                }
            }
        }
    }
}
}