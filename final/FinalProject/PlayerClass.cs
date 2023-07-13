using System.Collections.Generic;

namespace Starfinder {
class PlayerClass : Attribute {
    private static string[] _preselectedClassName = {"Envoy", "Mechanic", "Mystic", "Operative", "Solarian", "Soldier", "Technomancer"};
    private static int[] _preselectedClassHealth = {6, 6, 6, 6, 7, 7, 5}, _preselectedClassProficencyBonus = {8, 4, 6, 8, 4, 4, 4};
    private string[,] _preselectedClassProfisancies = {{"Acrobatics", "Athletics", "Bluff","Computers", "Culture", "Diplomacy", "Discuise", "Engineering", "Intimidate", "Medicine", "Preception", "Piloting", "Sense Motive", "Slight of Hand", "Stealth"},{"Athletics", "Computers", "Engineering", "Medicine", "Preception", "Physical Science", "Piloting", "NULL", "NULL", "NULL", "NULL", "NULL", "NULL", "NULL", "NULL"},{"Bluff", "Culture", "Diplomacy", "Discuise", "Intimidate", "Life Sciance", "Medicine", "Mysticism", "Preception", "Sense Motive", "Survival", "NULL", "NULL", "NULL", "NULL"},{"Acrobatics", "Athletics", "Bluff","Computers", "Culture", "Discuise", "Engineering", "Intimidate", "Medicine", "Preception", "Piloting", "Sense Motive", "Slight of Hand", "Stealth", "Survival"},{"Acrobatics", "Athletics", "Diplomacy", "Intimidate", "Mysticism", "Preception", "Physical Science", "Sense Motive", "Stealth", "NULL", "NULL", "NULL", "NULL", "NULL", "NULL"},{"Acrobatics", "Athletics", "Engineering", "Intimidate", "Medicine", "Piloting", "Survival", "NULL", "NULL", "NULL", "NULL", "NULL", "NULL", "NULL", "NULL"},{"Computers", "Engineering", "Life Sciance", "Mysticism", "Physical Science", "Piloting", "Slight of Hand", "NULL", "NULL", "NULL", "NULL", "NULL", "NULL", "NULL", "NULL"}};
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
        _profStat = (string[])_preselectedClassProfisancies.GetValue(prepickedClass);

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