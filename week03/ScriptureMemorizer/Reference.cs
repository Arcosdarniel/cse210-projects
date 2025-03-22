public class Reference
{
    private string _book;
    private int _chapter;
    private int _firstVerse;
    private int _lastVerse;
    

public Reference()
{
    _book = "";
    _chapter = 0;
    _firstVerse = 0;
    _lastVerse = 0;
}
public Reference(string book, int chapter, int firstVerse, int lastVerse)
{
    _book = book;
    _chapter = chapter;
    _firstVerse = firstVerse;
    _lastVerse = lastVerse;
}
public Reference(string book, int chapter, int firstVerse)
{
    _book = book;
    _chapter = chapter;
    _firstVerse = firstVerse;
}
    public static string FileGetter()
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(0, 9);
        string fileName = ("Scriptures.txt");
        string directoryPath = @"C:\CSE 210\cse210-projects\week03\ScriptureMemorizer";
        string filePath = Path.Combine(directoryPath,fileName);
        string[] references = System.IO.File.ReadAllLines(filePath);
        string line = references[number];
        return line;
    }
    
    public string GetScripture()
    {   
        string reference = FileGetter();
        string[] referenceArray = reference.Split("-");
        string scripture = "";
   

            if (referenceArray.Length >= 5)
            {   
                _book = referenceArray[0];
                _chapter = int.Parse(referenceArray[1]);
                _firstVerse = int.Parse(referenceArray[2]);
                _lastVerse = int.Parse(referenceArray[3]);

                scripture = ($"{referenceArray[0]}-{referenceArray[1]}-{referenceArray[2]}-{referenceArray[3]}");
                
            }
            else if (referenceArray.Length == 4)
            {
                _book = referenceArray[0];
                _chapter = int.Parse(referenceArray[1]);
                _firstVerse = int.Parse(referenceArray[2]);
                _lastVerse = 0;

                scripture = ($"{referenceArray[0]}-{referenceArray[1]}-{referenceArray[2]}");
            }       
        return scripture;
    }

    public string GetDisplayText()
    {
        string displayText = "";
        if (_lastVerse == 0)
        {
            displayText = ($"{_book} {_chapter}:{_firstVerse}");
        }
        else
        {
            displayText = ($"{_book} {_chapter}:{_firstVerse}-{_lastVerse}");
        }
        return displayText;
    }
}