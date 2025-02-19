using System;
using System.IO; 

public class Journal
{
    private List<Entry> _entries = new List<Entry>(); // A journal is a list of entries.

  
    public void AddEntry(Entry newEntry) // Add a new entry in the journal 
    {
        newEntry.GetNewEntry(); 
        _entries.Add(newEntry); 
    }

    private void AddEntryFromFile(string date, string promptText, string entryText, string mood) // Add to the current journal an entry that already has information. 
    {
        Entry entry = new Entry();
        entry = entry.GetOldEntry(date, promptText, entryText, mood); // Organize the information obtained from the file.
        _entries.Add(entry); // Add this entry to the journal.
    }

    public void DisplayAll() // Display the journal (list of entries at the moment) on the terminal.  
    {
        List<Entry> entries = GetEntriesList(); // Get the journal.
        foreach (Entry entry in entries) // Loop in each and every element in the list.
        {
            entry.Display(); // Display each entry on the terminal.
        }

    }

    

    public void SaveToFile(string file) // Save the current journal to a .txt file .
    {
        List<Entry> entriesList = GetEntriesList(); // Get the current journal as a list.

        using (StreamWriter outputFile = new StreamWriter(file)) 
        {
            foreach (Entry entry1 in entriesList) 
            {
                string entry = entry1.SortEntryForRecord();
                outputFile.WriteLine(entry);
            }
        }

        
        Console.WriteLine($"\nSaving your journal in {file}... \nSaving successfull.");
    }

    public void LoadFromFile(string file) 
    {
        Console.WriteLine($"Loading your Journal from {file}..."); 
        
        string[] lines = System.IO.File.ReadAllLines(file); 

        foreach (string line in lines) 
        {
            string[] parts = line.Split(" //#// "); 

            string date = parts[0]; // Part 1 = Index 0 = Date of the entry.
            string promptText = parts[1]; // Part 2 = Index 1 = Prompt of the entry.
            string entryText = parts[2]; // Part 3 = Index 2 = Text of the entry.
            string mood = parts[3]; // Part 4 = Index 3 = Mood/feelings.

            AddEntryFromFile(date, promptText, entryText, mood); // Adds the entry to the current journal.
        }
    }

    

    private List<Entry> GetEntriesList() // Get a list of Entries to use later.
    {
        List<Entry> entries = _entries; // Use the list in the current journal.

        return entries; // Return the list.
    }

}