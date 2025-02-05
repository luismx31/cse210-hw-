using System;
using System.Net;

public class Video
{
    public string _title;
    public string _author;
    public int _length;

    public List<Comment> Comments;

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        Comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        Comments.Add(comment);
    }

    public int GetCommentAmount()
    {
        return Comments.Count;
    }






}


