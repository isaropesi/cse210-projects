using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video
        {
            Title = "Video 1",
            Author = "Author 1",
            Length = 120,
            Comments = new List<Comment>
            {
                new Comment { CommenterName = "User 1", CommentText = "Great video!" },
                new Comment { CommenterName = "User 2", CommentText = "Nice content!" }
            }
        };
        videos.Add(video1);

        Video video2 = new Video
        {
            Title = "Video 2",
            Author = "Author 2",
            Length = 180,
            Comments = new List<Comment>
            {
                new Comment { CommenterName = "User 3", CommentText = "Awesome video!" },
                new Comment { CommenterName = "User 4", CommentText = "Thanks for sharing!" }
            }
        };
        videos.Add(video2);

        // Display information for each video
        foreach (Video video in videos)
        {
            Console.WriteLine("Title: " + video.Title);
            Console.WriteLine("Author: " + video.Author);
            Console.WriteLine("Length: " + video.Length + " seconds");
            Console.WriteLine("Number of comments: " + video.GetCommentCount());

            Console.WriteLine("Comments:");
            foreach (Comment comment in video.Comments)
            {
                Console.WriteLine("- " + comment.CommenterName + ": " + comment.CommentText);
            }

            Console.WriteLine();
        }

        Console.ReadLine();
    }
}