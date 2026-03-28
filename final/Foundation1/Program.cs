using System;

class Program
{
    static void Main(string[] args)
    {
        Comment comment1 = new Comment("Alice", "Great video!");
        Comment comment2 = new Comment("Bob", "Thanks for the explanation.");
        Comment comment3 = new Comment("Charlie", "I learned a lot from this.");
        Comment comment4 = new Comment("Dave", "Very helpful, thanks!");
        Comment comment5 = new Comment("Eve", "Can you make another video on this topic?");
        Comment comment6 = new Comment("Frank", "This was a bit confusing, can you clarify?");
        Comment comment7 = new Comment("Steve", "This has a bunch of great tips!");
        Comment comment8 = new Comment("Ashley", "Does this work with my HTML and CSS projects?");
        Comment comment9 = new Comment("Jeff", "Can you do some more with C# in your next video?");

        List<Comment> commentsForVideo1 = new List<Comment> {comment1, comment2, comment3};
        List<Comment> commentsForVideo2 = new List<Comment> {comment4, comment5, comment6};
        List<Comment> commentsForVideo3 = new List<Comment> {comment7, comment8, comment9};

        Video video1 = new Video("How to Code in C#", "John Doe", 300, commentsForVideo1);
        Video video2 = new Video("Introduction to Python", "Jane Smith", 240, commentsForVideo2);
        Video video3 = new Video("Advanced JavaScript Techniques", "Bob Johnson", 360, commentsForVideo3);

        video1.DisplayVideoInfo();
        video2.DisplayVideoInfo();
        video3.DisplayVideoInfo();
    }
}