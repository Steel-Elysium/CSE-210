using System;

namespace Memorize{ 
class Start
{
    ///<summary>
    ///
    ///</summary>

    static void Main(string[] args){
        //Console.WriteLine("Hello Develop03 World!");
        Scripture toMemorize = new Scripture();
        int choice;
        bool exit = false;
        while(!exit){
            choice = UserInteraction.Menu();
            switch(choice){
                case 1:
                    UserInteraction.Display(toMemorize);
                    break;
                case 2:
                    toMemorize = UserInteraction.EnterScripture();
                    break;
                case 3:
                    int amountToHide;
                    amountToHide = UserInteraction.HideScripture();
                    toMemorize.HideRandomWords(amountToHide);
                    break;
                case 4: 
                    toMemorize.ShowAllWords();
                    break;
                case 6:
                    exit = true;
                    break;
                default:
                    break;
            }
        }
    }
}
}