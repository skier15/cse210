
public class Journal
{
    List<Entry> _entries = new List<Entry>();

    public void Display()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void SaveToFile(string file)
    {

        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}#{entry._time}#{entry._promptText}#{entry._entryText}#");
            }
        }
    }

    public void LoadFromFile(string file)
    {
        _entries.Clear();
        
        string[] lines = System.IO.File.ReadAllLines(file);

        foreach (string line in lines)
        {
            string[] entryParts = line.Split("#");

            string date = entryParts[0];
            string time = entryParts[1];
            string promptText = entryParts[2];
            string entryText = entryParts[3];

            Entry entry = new Entry();
            
            entry._date = date; 
            entry._time = time; 
            entry._promptText = promptText;
            entry._entryText = entryText;

            _entries.Add(entry);
        }
    }
}