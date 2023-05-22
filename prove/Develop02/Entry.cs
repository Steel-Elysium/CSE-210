namespace Develop02{

public class Entry{

    ///<summary>
    ///The reponcability of the Entry class is to record (or store) a prompt, responce, and date
    ///</summary>

    private string _prompt;
    private string _responce;
    private string _date;

    public string GetAsString(){
        return ($"{this._date}\n{this._prompt}\n{this._responce}\n");
    }
    public void Store(string prompt, string responce, string date){
        this._prompt = prompt;
        this._responce = responce;
        this._date = date;
    }
    public void Store(string prompt, string responce){
        this._prompt = prompt;
        this._responce = responce;
        System.DateTime theCurrentTime = System.DateTime.Now;
        this._date = theCurrentTime.ToShortDateString();
    }
}
}