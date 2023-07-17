using System;
using System.Collections.Generic;

namespace Develop02{
public class Prompts{

    ///<summary>
    /// The Responcability to manage the prompts
    ///</summary>

    private List<String> _prompts;
    private string _fileLocation;
    private Random _randomNumber;

    public Prompts(){
        _fileLocation = "./prompts.csv";
        _prompts = FileManagement.ReadFile(_fileLocation);
        _randomNumber = new Random();
    }
    public Prompts(string fileLocation){
        _fileLocation = fileLocation;
        _prompts = FileManagement.ReadFile(_fileLocation);
        _randomNumber = new Random();
    }
    public Prompts(int randomSeed){
        _fileLocation = "./prompts.csv";
        _prompts = FileManagement.ReadFile(_fileLocation);
        _randomNumber = new Random(randomSeed);
    }
    public Prompts(string fileLocation, int randomSeed){
        _fileLocation = fileLocation;
        _prompts = FileManagement.ReadFile(_fileLocation);
        _randomNumber = new Random(randomSeed);
        
    }
    public string GeneratePrompt(){
        int nextRandom = _randomNumber.Next(_prompts.Count - 1);
        return _prompts[nextRandom];
    }
}
}