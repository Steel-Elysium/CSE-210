using System;

namespace Develop02{

class ConsoleMenu{

    ///<summary>
    /// This will manage the console menues for the user
    ///</summary>
    /*
    Write a new entry - Show the user a random prompt (from a list that you create), and save their response, the prompt, and the date as an Entry.
    Display the journal - Iterate through all entries in the journal and display them to the screen.
    Save the journal to a file - Prompt the user for a filename and then save the current journal (the complete list of entries) to that file location.
    Load the journal from a file - Prompt the user for a filename and then load the journal (a complete list of entries) from that file. This should replace any entries currently stored the journal.
    */
    private Prompts queries = new Prompts();

    public static Journal Start(Journal currentJournal){
        return GoToMenu(currentJournal);
    }
    public static Journal Start(){
        return GoToMenu();
    }
    public static Journal GoToMenu(Journal currentJournal){
        string userInput, CleanedInput;
        Entry NewEntry;
        Console.Out.WriteLine("\n\n\n");
        Console.Out.WriteLine("Enter in the Number for that menu option");
        Console.Out.WriteLine("1: Write New Entry");
        Console.Out.WriteLine("2: Display the Journal");
        Console.Out.WriteLine("3: Save the Journal\n");
        Console.Out.WriteLine("4: Load a Journal\n");
        Console.Out.WriteLine("5: End");
        Console.Out.Write("Enter in your choice: ");
        userInput = Console.In.ReadLine();
        CleanedInput = userInput.Trim();
        switch (CleanedInput[0]){
            case '1':
                NewEntry = MakeEntry();
                currentJournal.StoreEntry(NewEntry);
                currentJournal = GoToMenu(currentJournal);
                break;
            case '2':
                DisplayJournal(currentJournal);
                currentJournal = GoToMenu(currentJournal);
                break;
            case '3':
                SaveJournal(currentJournal);
                currentJournal = GoToMenu(currentJournal);
                break;
            case '4':
                currentJournal = LoadJournal();
                currentJournal = GoToMenu(currentJournal);
                break;
            case '5':
                break;
            default:
                currentJournal = GoToMenu(currentJournal);
                break;
        }
        return currentJournal;
    }
    public static Journal GoToMenu(){
        Entry newEntry;
        Journal newJournal = new Journal(); 
        string userInput, CleanedInput;
        Console.Out.WriteLine("\n\n\n");
        Console.Out.WriteLine("Enter in the Number for that menu option");
        Console.Out.WriteLine("1: Write New Entry");
        Console.Out.WriteLine("2: Display the Journal");
        Console.Out.WriteLine("3: Load a Journal\n");
        Console.Out.WriteLine("4: Exit");
        Console.Out.Write("Enter in your choice: ");
        userInput = Console.In.ReadLine();
        CleanedInput = userInput.Trim();
        switch (CleanedInput[0]){
            case '1':
                newEntry = MakeEntry();
                newJournal.StoreEntry(newEntry);
                newJournal = GoToMenu(newJournal);
                break;
            case '2':
                DisplayJournal(newJournal);
                GoToMenu(newJournal);
                break;
            case '3':
                newJournal = LoadJournal();
                newJournal = GoToMenu(newJournal);
                break;
            case '4':
                break;
            default:
                newJournal = GoToMenu(newJournal);
                break;
        }
        return newJournal;
    }
    public static Entry MakeEntry(){

    }
    public static void DisplayJournal(Journal currentJournal){

    }
    public static void SaveJournal(Journal currentJournal){

    }
    public static Journal LoadJournal(){

    }
}

}