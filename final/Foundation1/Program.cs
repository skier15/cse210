using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation1 World!");
        Console.WriteLine("Abstraction with YouTube Videos");
        Console.WriteLine();

        // 4 videos created using the Constructor, so as not to violate 
        // the principle of Encapsulation. We could also use getters and setters 
        // for the properties that we used for Comments.
        // Assigning a property directly (video1._title = "Horse riding") violates 
        // the principle of Encapsulation.
        Video video1 = new Video("Horse riding", "Sandra Williams", 15);
        Video video2 = new Video("Summer holidays", "Edward Taylor", 180);
        Video video3 = new Video("Diving", "Danny Thomas", 50);
        Video video4 = new Video("My Wedding", "Louis Hunter", 60);

        // 4 lists of comments
        List<Comment> commentsList1 = new List<Comment>()
        {
            new Comment("Alvin Rios", "What a good video!"),
            new Comment("Kathryn Price", "Incredible!!!"),
            new Comment("Sandra Williams", "Thanks for good comments."),
            new Comment("Elizabeth White", "Nice video!"),
        };

        List<Comment> commentsList2 = new List<Comment>()
        {
            new Comment("Audrey Ramirez", "Good!!!"),
            new Comment("Sherry Holland", "Wow!!!"),
            new Comment("Edward Taylor", "Thanks"),
            new Comment("James Jones", "Nice!"),
        };

        List<Comment> commentsList3 = new List<Comment>()
        {
            new Comment("Michael Ballard", "Very good!"),
            new Comment("Helen Hunter", "Brilliant!"),
            new Comment("Danny Thomas", "I appreciate it"),
            new Comment("Robert Gutierrez", "One more comment :)"),
        };

        List<Comment> commentsList4 = new List<Comment>()
        {
            new Comment("James King", "Nothing unusual :/"),
            new Comment("Matthew Baker", "Cool!!!"),
            new Comment("Robert Blake", "Awesome :D"),
            new Comment("Louis Hunter", "Thx friends :*"),
        };

        // Setting comments to videos
        video1.SetComments(commentsList1);
        video2.SetComments(commentsList2);
        video3.SetComments(commentsList3);
        video4.SetComments(commentsList4);

        // Putting each of these videos in a list.
        List<Video> videos = new List<Video>();
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);

        // Iterating through the list of videos 

        foreach (Video video in videos)
        {
            Console.WriteLine("<------------------------------------------->");
            Console.WriteLine($"Title: [{video.GetTitle()}], Author: {video.GetAuthor()}");
            Console.WriteLine($"Video length: {video.GetLength()}, Number of comments: {video.NumberOfComments()}");
            
            Console.WriteLine($"Comments:");
            
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"      \"{comment.GetCommentText()}\"");
                Console.WriteLine($"                  by {comment.GetAuthorName()}");
            }
        }
    }
}