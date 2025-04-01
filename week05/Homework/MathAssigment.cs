public class MathAssigment : Assigment
{
    private string _textBooksSeccion;
    private string _problem;
    
public MathAssigment() : base()
{
    _textBooksSeccion = "Unknown";
    _problem = "Unknown";
}
public MathAssigment(string name, string topic, string textBooksSeccion, string problem) : base(name, topic)
{
    _textBooksSeccion = textBooksSeccion;
    _problem = problem;
}

public string GetHomeworkList()
{
    return ($"{_textBooksSeccion} - {_problem}");
}
}
