using System.Collections.Generic;
using System;
namespace Memorize{
class Scripture{
    ///<summary>
    /// This will 
    ///</summary>
    private List<Word> _words;
    public Scripture(){
        _words = new List<Word>();
    }
    public Scripture(string Scripture){
        _words = EnterScripture(Scripture);
    }
    public Scripture(List<Word> Scripture){
        _words = Scripture;
    }
    public List<Word> EnterScripture(string Scripture){
        List<Word> listOfWords = new List<Word>();
        string[] words = Scripture.Split(" ");
        foreach(string word in words){
            Word newWord = new Word(word);
            listOfWords.Add(newWord);
        }
        return listOfWords;
    }
    public void SetWords(string words){
        _words = EnterScripture(words);
    }
    public string GetWords(){
        string scripture = "";
        foreach(Word word in _words){
            scripture += word.GetWord() + " ";
        }
        return scripture;
    }
    public void HideRandomWords(int amountToHide){
        DateTime date = new DateTime();
        Random randNum = new Random(date.Millisecond);
        for(int i = 0; i < amountToHide; i++){
            int nextNum;
            int errorCheck = 0;
            do{
                nextNum = randNum.Next(_words.Count - 1);
                errorCheck++;
            }while(_words[nextNum].isHidden()||errorCheck > 15);
            _words[nextNum].Hide();
        }
    }
    public void HideRandomWords(){
        Random randNum = new Random();
        int x;
        for(int i = 0; i < 3; i++){
            int nextNum;
            x = 0;
            int errorCheck = 0;
            do{
                x++;
                nextNum = randNum.Next(_words.Count - 1);
                errorCheck++;
                Console.Out.WriteLine(x);
            }while(_words[nextNum].isHidden()||errorCheck > 15);
            _words[nextNum].Hide();
        }
    }
    public void ShowAllWords(){
        foreach(Word word in _words){
            word.Show();
        }
    }
}
}