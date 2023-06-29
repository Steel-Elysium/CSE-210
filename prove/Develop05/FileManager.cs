using System.Collections.Generic;
using System.IO;
namespace Develop05{
public static class FileManager{
    public static void SaveGoals(List<Goal> goals, string saveLocation){
        StreamWriter outfile = new StreamWriter(saveLocation);
        foreach(Goal goal in goals){
            outfile.WriteLine(goal.GetSaveData());
        }
    }
    public static List<Goal> LoadGoals(string saveLocation){
        List<Goal> goals = new List<Goal>();
        string[] fileData = System.IO.File.ReadAllLines(saveLocation);
        char[] seperators = {',', ':'};
        Goal saveGoal = new Goal();
        foreach(string line in fileData){
            string[] items = line.Split(seperators);
            switch (items[0]){
                case "Goal":
                saveGoal = new Goal(items[1], items[2], int.Parse(items[3]), bool.Parse(items[4]));
                break;
                case "Eternal":
                saveGoal = new Eternal(items[1], items[2], int.Parse(items[3]), int.Parse(items[4]));
                break;
                case "Checklist":
                saveGoal = new Checklist(items[1], items[2], int.Parse(items[3]), bool.Parse(items[4]), int.Parse(items[5]), int.Parse(items[6]), int.Parse(items[7]));
                break;
            }
            goals.Add(saveGoal);
        }
        return goals;
    }
}
}