using System.Collections.Generic;
using System.IO;
namespace Develop02{
public static class FileManagement{
    ///<summary>
    /// this will manage the files loading and saving
    ///</summary>

    public static void SaveToFile(List<string> SaveData, string SaveLocation, string FileName){
        string FilePath = SaveLocation + "\\" + FileName; 
        CreateFile(FilePath);
        StreamWriter outFile = new StreamWriter(FilePath);
        foreach (string line in SaveData){
            outFile.WriteLine(line);
        }
    }
    public static void SaveToFile(List<string> SaveData, string FilePath){
        CreateFile(FilePath);
        StreamWriter outFile = new StreamWriter(FilePath);
        foreach (string line in SaveData){
            outFile.WriteLine(line + ',');
        }
    }
    public static void CreateDirectoryFile(string DirectoryName){
        if(!Directory.Exists(DirectoryName)){
            Directory.CreateDirectory(DirectoryName);
        }
    }
    public static void CreateFile(string fileLocation, string FileName){
        string FilePath = fileLocation + "\\" + FileName;
        if(!File.Exists(FilePath)){
            File.Create(FilePath);
        }
    }
    public static void CreateFile(string FilePath){
        if(!File.Exists(FilePath)){
            File.Create(FilePath);
        }
    }
    public static List<string> ReadFile(string FilePath){
        List<string> FileContents = new List<string>();
        string[] DirtyInputs;
        string CleanedInput;
        if(File.Exists(FilePath)){
            DirtyInputs = File.ReadAllLines(FilePath);
            foreach(string line in DirtyInputs){
                CleanedInput = line.Trim();
                CleanedInput = CleanedInput.Trim(',');
                FileContents.Add(CleanedInput);
            }
        }
        return FileContents;
    }
    
}
}