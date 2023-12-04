public class Comment
{
    public string CommenterName { get; set; }
    public string CommentText { get; set; }

    // Constructor to initialize Comment object
    public Comment(string commenterName, string commentText)
    {
        CommenterName = commenterName;
        CommentText = commentText;
    }
}