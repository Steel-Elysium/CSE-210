using System.Collections.Generic;
using System.Diagnostics.Contracts;

namespace Starfinder {
class Character {

    private List<Stat> _SkillScores; // 0-5 Stats, 6-26 Skills 
    private List<Attribute> _details; // 0 Class, 1 Race, 2 Theme
    private int _maxHealthPoints, _maxStaminaPoints, _maxResolvePoints, _level;
    private int[] _charAlignment;
    private string[,] _alignments = {{"Lawful Good","Neutral Good","Chaotic Good"}, {"Lawful Neutral","Neutral","Chaotic Neutral"}, {"Lawful Evil","Neutral Evil","Chaotic Evil"}};
    private string[] _skillNames = {"STR", "DEX", "CON", "INT", "WIS", "CHA", "Acrobatics", "Athletics", "Bluff", "Computers", "Culture", "Diplomacy", "Discuise", "Engineering", "Intimidate", "Life Sciance", "Medicine", "Mysticism", "Preception", "Physical Science", "Piloting", "Sense Motive", "Slight of Hand", "Stealth", "Survival", "Profession 1", "Profession 2"};
    int[] _skillProf = {1, 0, 5, 3, 3, 5, 5, 3, 5, 3, 3, 4, 4, 3, 1, 4, 1, 1, 4, -1, -1};
    public Character(){
        _SkillScores = new List<Stat>();
        for(int i = 0; i < 27; i++){
            if(i < 6){
                _SkillScores.Add(new Stat(_skillNames[i]));
            }else{
                _SkillScores.Add(new Skill(_skillNames[i]));
            }
        }
        SetProficiancies();
        _level = 1;
        _details = new List<Attribute>();
        _details.Add(new PlayerClass());
        _details.Add(new Race());
        _details.Add(new Theme());
        foreach(Attribute detail in _details){
            detail.StartUp(_SkillScores);
        }
    }
    public Character(int[] statBlock){ // size 6 array
        Contract.Ensures(statBlock.Length == 6);
        _SkillScores = new List<Stat>();
        for(int i = 0; i < 27; i++){
            if(i < 6){
                _SkillScores.Add(new Stat(_skillNames[i]));
            }else{
                _SkillScores.Add(new Skill(_skillNames[i]));
            }
        }
        for(int i = 0; i < 6; i++){
            _SkillScores[i].EditStat(statBlock[i]);
        }
        SetProficiancies();
        _level = 1;
        _details = new List<Attribute>();
        _details.Add(new PlayerClass());
        _details.Add(new Race());
        _details.Add(new Theme());
        foreach(Attribute detail in _details){
            detail.StartUp(_SkillScores);
        }
    }
    public Character(int[] statBlock, int[] attributes){
        Contract.Ensures(statBlock.Length == 6);
        Contract.Ensures(attributes.Length == 3);
        _SkillScores = new List<Stat>();
        for(int i = 0; i < 27; i++){
            if(i < 6){
                _SkillScores.Add(new Stat(_skillNames[i]));
            }else{
                _SkillScores.Add(new Skill(_skillNames[i]));
            }
        }
        for(int i = 0; i < 6; i++){
            _SkillScores[i].EditStat(statBlock[i]);
        }
        SetProficiancies();
        _level = 1;
        _details = new List<Attribute>();
        _details.Add(new PlayerClass(attributes[0]));
        _details.Add(new Race(attributes[1]));
        _details.Add(new Theme(attributes[2]));
        foreach(Attribute detail in _details){
            detail.StartUp(_SkillScores);
            _maxHealthPoints += detail.GetHealth();
        }
        _details[0].StartUp(_SkillScores);
        _maxHealthPoints += _SkillScores[2].GetModifier();
        PlayerClass placeholderclass = new PlayerClass(attributes[0]);
        _maxStaminaPoints = placeholderclass.GetStaminaBase() + _SkillScores[2].GetModifier();
        if(_SkillScores[4].GetModifier() < 0){
            _maxResolvePoints = 1;
        }else{
            _maxResolvePoints = _SkillScores[4].GetModifier() + 1;
        }
    }
    public void SetAlignment(int[] alignment){
        Contract.Ensures(alignment.Length == 2);
        _charAlignment = alignment;
    }
    public string DisplayAlignment(){
        return _alignments[_charAlignment[0], _charAlignment[1]];
    }
    private void SetProficiancies(){
        for(int i = 6; i < 24; i++){
            if(-1 != _skillProf[i-6]){
                _SkillScores[i].EditStat(_SkillScores[_skillProf[i-6]].GetStat());
            }
        }
    } 
}
}