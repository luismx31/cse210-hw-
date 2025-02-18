using System;




public class Assignment
{
    protected string _studentName;
    protected string _topic;


    public Assignment(string studentName,string topic)
    {
        _studentName = studentName;
        _topic = topic;


    }

    

    //get summary getter
    public string GetSummary()
    {
        return 
        _studentName + "-"+_topic;

    }

    // getter for private variables

    public string GetStudentName()
    {
        return _studentName;
    }

    public string GetTopic()
    {
        return _topic;
    }



}