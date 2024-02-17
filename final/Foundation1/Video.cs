public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;

    public Video()
    {
        _title = "title";
        _author = "author";
        _length = 0;
        _comments = new List<Comment>();
    }
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }
    
    // This function get title (Getter)
    public string GetTitle()
    {
        return _title;
    }

    // This function get author (Getter)
    public string GetAuthor()
    {
        return _author;
    }

    // This function get video length (Getter)
    public int GetLength()
    {
        return _length;
    }

    // This function get comments (Getter)
    public List<Comment> GetComments()
    {
        return _comments;
    }

    // This function set comments (Setter)
    public void SetComments(List<Comment> comments)
    {
        _comments = comments;
    }

    // This function return number of comments
    public int NumberOfComments()
    {
        return _comments.Count();
    }
}