public class Video
{
    private string _title;
    private string _author;
    private int _duration;
    private List<Comments> _comments;
    public Video(string title, string author, int duration)
    {
        _title = title;
        _author = author;
        _duration = duration;
        _comments = new List<Comments>();
    }
    public void AddComment(string userName,string comment)
    {
        _comments.Add(new Comments(userName,comment));
     
    }
    public void GetDisplayVideo()
    {   
        Console.WriteLine($"{_title} by {_author}");
        Console.WriteLine($"Duration: {_duration} seconds");
    }
    
    public void GetNumberOfComments()
    {
        Console.WriteLine($"Number of comments: {_comments.Count}");
        Console.WriteLine(" ");
    }
}


