using System.Collections.Generic;
using System;

namespace Starfinder {
class Race : Attribute {
    private Random rand = new Random();
    private static string[] _preselectedName = {"Android", "Human", "Kasatha", "Lachunta (Damaya)", "Lachunta (Korasha)", "Shirren", "Vesk", "Ysoki"};
    private static int[] _preselectedHealth = {4, 4, 4, 4, 4, 6, 6, 2};
    private string[,] _preselectedStats = {{"DEX", "INT", "CHA"}, {"ANY", null, null}, {"STR", "INT", "WIS"},{"CON", "INT", "CHA"}, {"STR", "WIS", "CHA"}, {"CON", "WIS", "CHA"}, {"STR", "CON", "INT"}, {"STR", "DEX", "INT"}};
    private bool[,] _isPreselectedStatPositive = {{true, true, false}, {true, true, true}, {true, false, true}, {false, true, true}, {true, false, true}, {true, true, false}, {true, true, false}, {false, true, true}};
    public Race() : base(){}
    public Race(string name) : base(name){}
    public Race(string name, int bonusHealth) : base(name, bonusHealth){}
    public Race(int prepickedRace) : base(_preselectedName[prepickedRace], _preselectedHealth[prepickedRace]){
        for(int i = 0; i < 3; i++){
            if(_preselectedStats[prepickedRace, i] == null){
                break;
            }
            if(_preselectedStats[prepickedRace, i] == "ANY"){
                int randomStat = rand.Next(0,5);
                string[] stat = {"STR", "DEX", "CON", "INT", "WIS", "CHA"};
                base.AddModifier(stat[randomStat], 2);
            }else{
                if(_isPreselectedStatPositive[prepickedRace, i]){
                    base.AddModifier(_preselectedStats[prepickedRace, i], 2);
                }else{
                    base.AddModifier(_preselectedStats[prepickedRace, i], -2);
                }
            }
        }
    }
    public Race(string name, int bonusHealth, string statName) : base(name, bonusHealth){
        base.AddModifier(statName, 2);
    }
    public Race(string name, int bonusHealth, string StatName1, bool statPositive1, string statName2, bool statPositive2, string statName3, bool statPositive3) : base(name, bonusHealth){
        if(statPositive1){
            base.AddModifier(StatName1, 2);
        }else{
            base.AddModifier(StatName1, -2);
        }
        if(statPositive2){
            base.AddModifier(statName2, 2);
        }else{
            base.AddModifier(statName2, -2);
        }
        if(statPositive3){
            base.AddModifier(statName3, 2);
        }else{
            base.AddModifier(statName3, -2);
        }
    }
    public void AddStat(string name, int modifier){
        base.AddModifier(name, modifier);
    }
    public override void LevelUp(int currentLevel){
        throw new System.NotImplementedException();
    }

    public override void StartUp(List<Stat> startingStats){
        for(int i = 0; i < 6; i++){
            foreach(StatModifier modifier in base.GetModifiers()){
                if(modifier.statName == startingStats[i].GetName()){
                    startingStats[i].AddStat(modifier.statBonus);

                }
            }
        }
    }
}
}