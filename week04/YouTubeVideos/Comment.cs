

public class Comment
{
    private string _commentName;
    private string _commentText;

    public Comment()
    {
        _commentName = "";
        _commentText = "";
    }

    public Comment(string commentName, string commentText)
    {
        _commentName = commentName;
        _commentText = commentText;
    }

    public string DisplayComment()
    {
        return $"{_commentName} {_commentText}";
    }
}