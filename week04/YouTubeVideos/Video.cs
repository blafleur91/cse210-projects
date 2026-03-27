

using System.Reflection;
using System.Transactions;

public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comment = new List<Comment>();

    public Video()
    {
        _title = "";
        _author = "";
        _length = 0;
    }

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public string DisplayVideo()
    {
        return $"Video Title: {_title}| Author: {_author}| Length in Seconds: {_length}";
    }

    public void DisplayVideoComments()
    {
        foreach (var comment in _comment)
        {
            Console.WriteLine(comment.DisplayComment());
        }
    }

    public void VideoComments(string commentName, string commentText)
    {
        Comment comment = new Comment(commentName, commentText);
        _comment.Add(comment);
    }

    public int GetNumberOfComments()
    {
        return _comment.Count();
    }
}