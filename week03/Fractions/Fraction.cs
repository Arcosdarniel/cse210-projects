public class Fraction
{
    private int _top;
    private int _bot;

    public Fraction()
    {
        _top = 1;
        _bot = 1;
    }
    public Fraction(int number)
    {
        _top = number;
        _bot = 1;
    }
    public Fraction(int number1,int number2)
    {
        _top = number1;
        _bot = number2;
    }
    public int GetTop()
    {
        return _top;
    }
    public int GetBot()
    {
        return _bot;
    }
    public void SetBoth(int top, int bot)
    {
        _top = top;
        _bot = bot;
    }
    public void SetTop(int top)
    {
        _top = top;
    
    }
     public void SetBot(int bot)
    {
        _bot = bot;
    
    }
        public string GetFractionString()
    {   
        string result = ($"{_top}/{_bot}");
        return result;
    }
    public double GetDecimalValue()
    {
        double result = (double)_top / (double)_bot;
        return result;
    }
    public void Display()
    {
        Console.WriteLine(GetFractionString());
        Console.WriteLine(GetDecimalValue());
    }
}
