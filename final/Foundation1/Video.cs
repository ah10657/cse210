using System;

class Video
{
    private string _title;
    private string _videoAuthor;
    private int _lengthInSeconds;
    private List<Comment> _comments;

    public Video(string title, string videoAuthor, int lengthInSeconds, List<Comment> comments)
    {
        _title = title;
        _videoAuthor = videoAuthor;
        _lengthInSeconds = lengthInSeconds;
        _comments = comments;
    }

    public void GetComment(Comment comment)
    {
        _comments.Append(comment);
    }

    public int GetCommentCount()
    {
        return _comments.Count;
    }

    public void DisplayVideoInfo()
    {
        Console.WriteLine($"\nTitle: {_title}");
        Console.WriteLine($"Author: {_videoAuthor}");
        Console.WriteLine($"Length: {_lengthInSeconds} seconds");
        Console.WriteLine($"Number of Comments: {_comments.Count}");
        Console.WriteLine($"{GetCommentCount()} Comments:");
        foreach (Comment comment in _comments)
        {
            Console.WriteLine($"- {comment.GetComment()}");
        }
    }
}