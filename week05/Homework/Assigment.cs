public class Assigment
{
    protected string _name = "";
    protected string _topic = "";

    public Assigment()
    {
        _name = "Anonymous";
        _topic = "Unknown";
    }
    public Assigment(string name, string topic)
    {
        _name = name;
        _topic = topic;
    }

    public string GetInfo()
    {
        return _name + " - " + _topic;
    }
}