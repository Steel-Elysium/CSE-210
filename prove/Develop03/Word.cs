using System.Linq;
namespace Memorize{
class Word{
    ///<summary>
    /// This will manage the words in the scripture
    ///</summary>
    private bool _isHidden;
    private string _word;
    public Word(){
        _isHidden = false;
        _word = "";
    }
    public Word(string word){
        _isHidden = false;
        _word = word;
    }
    public string GetWord(){
        string hiddenString = _word;
        char[] puntuation = {'(',')',',','.','\'','\\','/','\"','?','!'}; 
        if(_isHidden){
            hiddenString = "";
            foreach(char letter in _word){
                if(puntuation.Contains(letter)){
                    hiddenString = letter.ToString();
                }
                else{
                    hiddenString += " _";
                }
            }
        }
        return hiddenString;
    }
    public bool isHidden(){
        return _isHidden;
    }
    public void Hide(){
        _isHidden = true;
    }
    public void Show(){
        _isHidden = false;
    }
}
}