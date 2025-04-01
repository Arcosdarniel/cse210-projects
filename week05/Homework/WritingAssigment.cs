public class WritingAssigment : Assigment
{
    private string _title;

    public WritingAssigment() : base()
    {
        _title = "Unknown";
    }
    public WritingAssigment(string name, string topic, string title) : base(name, topic)
    {
        _title = title;
    }

    public string GetHomeworkList()
    {
        return ($"{_title} by {_name}");
    }
}