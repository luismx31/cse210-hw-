
public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity() : base("Reflecting Activity", "This activity will help you reflect on a thought or feeling.", 5)
    {
        _prompts = new List<string> { "How are you feeling today?", "What was a significant event for you recently?" };
        _questions = new List<string> { "Why do you think you feel this way?", "What can you learn from this experience?" };
    }

    public override void Run()
    {
        DisplayStartingMessage();

        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Count)];
        string question = _questions[random.Next(_questions.Count)];

        Console.WriteLine($"Prompt: {prompt}");
        Console.WriteLine($"Question: {question}");
        Console.WriteLine("Please reflect and write your thoughts:");

        string response = Console.ReadLine();

        ShowSpinner(2);

        Console.WriteLine($"Your reflection: {response}");

        DisplayEndingMessage();
    }
}