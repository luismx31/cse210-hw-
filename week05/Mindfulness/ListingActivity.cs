public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity() : base("Listing Activity", "This activity will help you reflect by listing things.", 5)
    {
        _prompts = new List<string> { "What are things you are grateful for?", "What are some positive events that happened today?" };
        _count = 0;
    }

    public override void Run()
    {
        DisplayStartingMessage();

        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Count)];
        Console.WriteLine($"Prompt: {prompt}");

        Console.WriteLine("Start listing your responses. Type 'done' when finished.");
        List<string> responses = new List<string>();

        while (true)
        {
            string response = Console.ReadLine();
            if (response.ToLower() == "done")
            {
                break;
            }
            responses.Add(response);
            _count++;
        }

        Console.WriteLine($"You listed {_count} responses.");
        ShowSpinner(2);

        DisplayEndingMessage();
    }
}