using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Your current score is: {_score}");
    }
    public void ListGoalNames()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }
    
    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        Console.Write("Which type of goal would you like to create? ");
        int type = int.Parse(Console.ReadLine());

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        if (type == 1)
        {
            _goals.Add(new SimpleGoal(name, description, points));
        }
        else if (type == 2)
        {
            _goals.Add(new EternalGoal(name, description, points));
        }
        else if (type == 3)
        {
            Console.Write("How many times does this goal need to be accomplished? ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());

            _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
        }

        Console.WriteLine("Goal created successfully!");
    }
    public void RecordEvent()
    {
        Console.WriteLine("Which goal did you accomplish?");
        ListGoalNames();

        int choice = int.Parse(Console.ReadLine());

        Goal selectedGoal = _goals[choice - 1];

        bool wasComplete = selectedGoal.IsComplete();

        selectedGoal.RecordEvent();

        if (selectedGoal is EternalGoal)
        {
            _score += selectedGoal.GetPoints();
        }
        else
        {
            if (!wasComplete)
            {
                _score += selectedGoal.GetPoints();
            }
        }

        if (!wasComplete && selectedGoal.IsComplete())
        {
            if (selectedGoal is ChecklistGoal checklist)
            {
                _score += checklist.GetBonus();
                Console.WriteLine("Bonus achieved!");
            }
        }

        Console.WriteLine($"You now have {_score} points.");
    }
    public void SaveGoals()
    {
        Console.Write("Enter filename to save: ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            //Save the score first
            outputFile.WriteLine(_score);

            //Save each goal
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals saved successfully!");
    }
    public void LoadGoals()
    {
        Console.Write("Enter filename to load: ");
        string filename = Console.ReadLine();

        string[] lines = File.ReadAllLines(filename);

        _goals.Clear();

        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string line = lines[i];
            string[] parts = line.Split(":");

            string goalType = parts[0];
            string[] goalData = parts[1].Split(",");

            if (goalType == "SimpleGoal")
            {
                SimpleGoal goal = new SimpleGoal(
                    goalData[0],
                    goalData[1],
                    int.Parse(goalData[2])
                );

                if (bool.Parse(goalData[3]))
                    goal.RecordEvent();

                _goals.Add(goal);
            }
            else if (goalType == "EternalGoal")
            {
                EternalGoal goal = new EternalGoal(
                    goalData[0],

                    goalData[1],

                    int.Parse(goalData[2])
                );

                _goals.Add(goal);
            }
            else if (goalType == "ChecklistGoal")
            {
                ChecklistGoal goal = new ChecklistGoal(
                    goalData[0],

                    goalData[1],

                    int.Parse(goalData[2]),

                    int.Parse(goalData[4]),

                    int.Parse(goalData[5])
                );

                for (int j = 0; j < int.Parse(goalData[3]); j++)
                {
                    goal.RecordEvent();
                }

                _goals.Add(goal);
            }
        }

        Console.WriteLine("Goals loaded successfully!");
    }

}