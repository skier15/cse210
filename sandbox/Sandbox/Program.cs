using System;


class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Length { get; set; }
    private List<Comment> comments = new List<Comment>();

    public void AddComment(string commenter, string text)
    {
        comments.Add(new Comment(commenter, text));
    }

    public int GetNumberOfComments()
    {
        return comments.Count;
    }

    public void DisplayInfo()
    {
        Console.WriteLine("Title: " + Title);
        Console.WriteLine("Author: " + Author);
        Console.WriteLine("Length: " + Length + " seconds");
        Console.WriteLine("Number of Comments: " + GetNumberOfComments());
        foreach (Comment comment in comments)
        {
            Console.WriteLine("Comment by " + comment.Commenter + ": " + comment.Text);
        }
        Console.WriteLine();
    }
}

class Comment
{
    public string Commenter { get; set; }
    public string Text { get; set; }

    public Comment(string commenter, string text)
    {
        Commenter = commenter;
        Text = text;
    }
}

class Program
{
    static void Main()
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video { Title = "Video 1", Author = "Author 1", Length = 120 };
        video1.AddComment("User1", "Great video!");
        video1.AddComment("User2", "Interesting content.");
        videos.Add(video1);

        Video video2 = new Video { Title = "Video 2", Author = "Author 2", Length = 180 };
        video2.AddComment("User3", "Nice job!");
        videos.Add(video2);

        foreach (Video video in videos)
        {
            video.DisplayInfo();
        }
    }
}

        