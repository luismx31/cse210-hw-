using System;
using System.Linq.Expressions;




public class MathAss : Assignment
{
    
    private string _textbookSection;
    private string _problems;

    public MathAss(string studentName, string topic, string textbookSection, string problems) : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;



    } 


    public string GetHomeworklist()
    {
        return $"Section: {_textbookSection}, Problems: {_problems}";

    }




} 