using System;


public class WritingAss : Assignment
{
    private string _title;


    public WritingAss(string studentName, string topic, string title): base(studentName,topic)
    {
        _title = title;
    }


    public string GetWritingInformation()
    {
        return $"{_title} by {_studentName}" ;
    }







}

