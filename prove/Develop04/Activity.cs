using System.Collections.Generic;

namespace Develop4{
class Activity{
    
    //private varibles 
    private int _duration, _animationStage;
    private string _startMessage, _endMessage;
    private List<string> _animation;

    // Constructors
    public Activity(){
        _animationStage = 0;
        _animation = new List<string>();
        _animation.Add("|");
        _animation.Add("\\");
        _animation.Add("-");
        _animation.Add("/");
        _duration = 3000;
        _startMessage = "Welcome to the activity!";
        _endMessage = "Thanks for doing the activity";
    }
    public Activity(int duration){
        _animationStage = 0;
        _animation = new List<string>();
        _animation.Add("|");
        _animation.Add("\\");
        _animation.Add("-");
        _animation.Add("/");
        _duration = duration;
        _startMessage = "Welcome to the activity!";
        _endMessage = "Thanks for doing the activity";
    }
    public Activity(string message){
        _animation.Add("|");
        _animation.Add("\\");
        _animation.Add("-");
        _animation.Add("/");
        _duration = 3000;
        _startMessage = message;
        _endMessage = "Thanks for doing the activity";

    }
    public Activity(string startMessage, string endMessage){
        _animation.Add("|");
        _animation.Add("\\");
        _animation.Add("-");
        _animation.Add("/");
        _duration = 3000;
        _startMessage = startMessage;
        _endMessage = endMessage;
    }
    public Activity(int duration, string message){
        _animation.Add("|");
        _animation.Add("\\");
        _animation.Add("-");
        _animation.Add("/");
        _duration = duration;
        _startMessage = message;
        _endMessage = "Thanks for doing the activity";

    }
    public Activity(int duration, string startMessage, string endMessage){
        _animation.Add("|");
        _animation.Add("\\");
        _animation.Add("-");
        _animation.Add("/");
        _duration = duration;
        _startMessage = startMessage;
        _endMessage = endMessage;

    }

    // Getters and Setters
    public string GetStartMessage(){
        return _startMessage;
    }
    public string GetEndMessage(){
        return _endMessage;
    }
    public int GetDuration(){
        return _duration;
    }
    public void SetDuration(int duration){
        _duration = duration;
    }
    // Public Funtions

    public string IterateAnimation(){
        _animationStage++;
        if(_animationStage == 4){
            _animationStage = 0;
        }
        return _animation[_animationStage];
    }
}
}