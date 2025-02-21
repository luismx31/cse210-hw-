public abstract class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public virtual void DisplayStartingMessage()
    {
        Console.WriteLine($"Starting { _name}: { _description}");
    }

    public virtual void DisplayEndingMessage()
    {
        Console.WriteLine($"End of { _name}. Hope you feel more mindful!");
    }

    public void ShowSpinner(int seconds)
    {
        Console.Write("Processing...");
        for (int i = 0; i < seconds; i++)
        {
            Thread.Sleep(1000);
            Console.Write(".");
        }
        Console.WriteLine();
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.WriteLine($"Time remaining: {i} seconds");
            Thread.Sleep(1000);
        }
    }

    public abstract void Run();
}

