using System.Collections.Generic;
namespace Develop05{
public class ConsoleMenuOption{
    private int _points;
    public ConsoleMenuOption(){
        _points = 0;
    }
    public virtual void Execute(ref List<Goal> goals){
    }
    public int GetPoints(){
        return _points;
    }
    protected void AddPoints(int points){
        _points += points;
    }
    protected void RemovePoints(int points){
        _points -= points;
    }
}
}