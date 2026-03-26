

using System.Reflection;
using System.Transactions;

public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comment;

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
        return $"{_title} {_author} {_length}";
    }

    public int GetNumberOfComments()
    {
        return _comment.Count();
    }
}