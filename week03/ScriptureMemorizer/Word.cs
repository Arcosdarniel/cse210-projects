public class Word
{
    private bool _isHidden;
    private string _text;

     public Word(string text)
    {
        _text = text;
        _isHidden = false; 
    }
    public void Hide()
    {
        _isHidden = true;
    }
    public void Show()
    {
        _isHidden = false;
    }
    public bool IsHidden()
    {
        return _isHidden;
    }
    public string GetDisplayText()
    {
        return _isHidden ? "_____" : _text;
    }
}