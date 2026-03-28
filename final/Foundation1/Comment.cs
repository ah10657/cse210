using System;

class Comment
{
    private string _commentAuthor;
    private string _comment;

    public Comment(string commentAuthor, string comment)
    {
        _commentAuthor = commentAuthor;
        _comment = comment;
    }

    public string GetComment()
    {
        return $"{_commentAuthor}: {_comment}";
    }
}