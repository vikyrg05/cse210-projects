using System;

public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing Activity";
        _description = "This activity will help relax by breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public void Run()
    {
        DisplayStartingMessage();

        int timePassed = 0;

        while (timePassed < _duration)
        {
            Console.WriteLine("Breathe in...");
            ShowCountDown(4);
            timePassed += 4;

            if (timePassed >= _duration)
            {
                break;
            }

            Console.WriteLine("Breathe out...");
            ShowCountDown(4);
            timePassed += 4;
        }

        DisplayEndingMessage();
    }
}