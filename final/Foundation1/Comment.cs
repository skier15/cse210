public class Comment
{
    // name of the person who made the comment
    private string _authorName;

    // text of the comment
    private string _commentText;

    public Comment(string authorName, string commentText)
    {
        _authorName = authorName;
        _commentText = commentText;
    }

    // This function get author name (Getter)
    public string GetAuthorName()
    {
        return _authorName;
    }

    // This function get comment text (Getter)
    public string GetCommentText()
    {
        return _commentText;
    }
}