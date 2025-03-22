public class Scripture
{
    private Reference _reference;
    private string _textRefere;  
    private List<Word> _words;
    public Scripture()
    {
        _reference = new Reference();
        _words = new List<Word>();
        string text = GetText(_reference.GetScripture());
        _textRefere = _reference.GetDisplayText();
        string[] words = text.Split(" ");
        foreach (string word in words)
        {
            _words.Add(new Word(word));
        }
    }
    public void HideRandomWord()
    {
        Random random = new Random();
        int hiddenCount = 0;

        while (hiddenCount < 1)
        {
            int index = random.Next(0, _words.Count);
            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
                hiddenCount++;
            }
        }
    }
    public string GetText(string reference)
    {
        string fileName = ("Scriptures.txt");
        string directoryPath = @"C:\CSE 210\cse210-projects\week03\ScriptureMemorizer";
        string filePath = Path.Combine(directoryPath,fileName);
        string[] references = System.IO.File.ReadAllLines(filePath);
        string text = "";
        foreach(string line in references )
        {
            if (line.Contains(reference))
            {
                string[] referenceArray = line.Split("-");
                if (referenceArray.Length >= 5)
                {
                    text = referenceArray[4];
                }
                else if (referenceArray.Length == 4)
                {
                    text = referenceArray[3];
                }
            }
        }   
        return text;
    }    
    public string GetDisplayText()
    {
        string scriptureText = "";
        foreach (Word word in _words)
        {
            scriptureText += word.GetDisplayText() + " ";
        }
        string displayText = ($"{_textRefere} {scriptureText}");
        return displayText;
    }
}

