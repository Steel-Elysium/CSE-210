using System.Collections.Generic;

namespace Starfinder {
class Theme : Attribute {
    private static string[] _allowedAttrobutes = {"Ace Pilot", "Priest", "Bounty Hunter", "Scholar", "Icon", "Spacefarer", "Mercenary", "Xenoseeker", "Outlaw"};
    private static string[] _statProf = {"DEX","WIS","CON","INT","CHA","CON","STR","CHA","DEX"};
    private static string[] _skillProf = {};
    public Theme() : base(){}
    public Theme(int prepickedTheme) : base(_allowedAttrobutes[prepickedTheme]){
        base.AddModifier(_statProf[prepickedTheme], 1);
    }
    public Theme(string name, string statName, string skillName) : base(name){
        base.AddModifier(statName, 1);
    }
    public override void LevelUp(int currentLevel){
        throw new System.NotImplementedException();
    }
    public override void StartUp(List<Stat> startingStats){
        for(int i = 0; i < 6; i++){
            if(startingStats[i].GetName() == base.GetModifier(0).statName){
                startingStats[i].AddStat(base.GetModifier(0).statBonus);
            }
        }
    }
    }
}