using System;
class Program
{
    static void Main(string[] args)
    {
        // Create a list of videos
        List<Video> videos = new List<Video>();

        // Add videos to the list
        Video video1 = new Video("Rending the veil of unbelief", "Come Follow Me Manual", 3600);
        video1.AddComment(new Comment("Amos", "Great teaching, very insightful!"));
        video1.AddComment(new Comment("Kelechi", "I love the way you explained topic."));
        video1.AddComment(new Comment("Charlie", "I do appreciate your teaching"));

        Video video2 = new Video("Top Electronics Brands in Nigeria", "Channels", 900);
        video2.AddComment(new Comment("Clint", "LG for life!"));
        video2.AddComment(new Comment("Eve", "Haier Thermocool all the way."));
        video2.AddComment(new Comment("Frank", "Hisense is great"));

        Video video3 = new Video("Understanding Abstraction", "BYU-I", 600);
        video3.AddComment(new Comment("Kelechi", "This video really clarified abstraction for me."));
        video3.AddComment(new Comment("Lifegate", "I appreciate the simple examples."));
        video3.AddComment(new Comment("Gutieres", "Could you do one on inheritance next?"));

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        // Display video information
        foreach (Video video in videos)
        {
            Console.WriteLine(video.GetDisplayText());
            Console.WriteLine("Comments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.GetDisplayText()}");
            }
            Console.WriteLine(); // Add spacing between videos
        }
    }
}
