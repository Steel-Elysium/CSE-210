using System.Collections.Generic;
namespace Develop02{
public class Journal{
    ///<summary>
    /// The Responcablility is to store entries
    ///</summary>
    public List<Entry> entries;
    public Journal(){
        this.entries = new List<Entry>();
    }
    public List<Entry> GetAllEntries(){
        return this.entries;
    }
    public void StoreEntry(Entry entry){
        if(!entries.Contains(entry)){
            entries.Add(entry);
        }
    }
} 
}