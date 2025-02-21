public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will guide you through a breathing exercise.", 5) { }

    public override void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("Breathe in... and out.");
        ShowCountDown(10); // Duration for the breathing activity
    
        ShowSpinner(5); // Show spinner after the activity

        DisplayEndingMessage();
    }
}