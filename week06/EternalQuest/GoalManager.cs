using System.IO;

public class GoalManager
{

            //  the way I am going to improve the program is by adding in a leveling system that progressively gets
            // higher the more you level up.
    private List<Goal> _goals = new List<Goal>();
    private int _score;
    private int _level;
    private int _scoreNeeded;

    public GoalManager()
    {
        _score = 0;
        _level = 1;
        _scoreNeeded = 250;
    }
        // IF CONFUSED ABOUT CODE MISSING, CHECK THE DROP DOWN ARROWS AND DON'T PANIC
    public void Start()
    {
        string input = "";

        Console.Clear();

        while (input != "6")
        {
            if (_score > _scoreNeeded)
            {
                _scoreNeeded = _scoreNeeded * 2;
                _level ++;
            }

            DisplayPlayerInfo();

            Console.WriteLine("Menu Options:");
            Console.WriteLine("\t1. Create New Goal");
            Console.WriteLine("\t2. List Goals");
            Console.WriteLine("\t3. Save Goals");
            Console.WriteLine("\t4. Load Goals");
            Console.WriteLine("\t5. Record Event");
            Console.WriteLine("\t6. Quit");
            Console.Write("Select a choice from the menu: ");
            input = Console.ReadLine();

            if (input == "1")
            {
                CreateGoal();
            }
            else if (input == "2")
            {
                Console.WriteLine("Your goals are: ");
                int number = 1;
                foreach (Goal i in _goals)
                {
                    Console.WriteLine(number + i.GetDetailsString());
                    number ++;
                }
            }
            else if (input == "3")
            {
                SaveGoals();
            }
            else if (input == "4")
            {
                LoadGoals();
            }
            else if (input == "5")
            {
                RecordEvent();
            }
            else if (input == "6")
            {
                Console.WriteLine("Thank you for using the Eternal Quest Program!");
            }
            else
            {
                Console.WriteLine("You have chosen an invalid input, please type a number to one of the options listed.");
            }
        }
    }
    // Start - This is the "main" function for this class. It is called by Program.cs, and then runs the menu loop.

    public void DisplayPlayerInfo()
    {
        Console.WriteLine();
        Console.WriteLine($"You have {_score} points.");
        Console.WriteLine($"You are currently level {_level}. You need {_scoreNeeded} points to level up!");
        Console.WriteLine();
    }
    // DisplayPlayerInfo - Displays the players current score.

    public void ListGoalNames()
    {
        int num = 1;

        foreach (Goal i in _goals)
        {
            // because GetStringRepresentation is for pulling from or giving to a text file, I can use that to split up the info in a way
            // that lets me do what the video shows.
            string fullData = i.GetStringRepresentation();

            string[] splitData = fullData.Split(":");
            string goalData = splitData[1];
            string[] splitGoalData = goalData.Split(",");
            string goalName = splitGoalData[0];

            Console.WriteLine($"{num}. {goalName}");
            num ++;
        }
    }
    // ListGoalNames - Lists the names of each of the goals.

    public void ListGoalDetails()
    {
        int num = 1;

        foreach (Goal i in _goals)
        {
            // because GetStringRepresentation is for pulling from or giving to a text file, I can use that to split up the info in a way
            // that lets me do what the video shows.
            string fullData = i.GetStringRepresentation();

            string[] splitData = fullData.Split(":");
            string goalData = splitData[1];
            string[] splitGoalData = goalData.Split(",");
            string goalDescription = splitGoalData[1];

            Console.WriteLine($"{num}. {goalDescription}");
            num ++;
        }
    }
    // ListGoalDetails - Lists the details of each goal (including the checkbox of whether it is complete).

    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("\t1. Simple Goal");
        Console.WriteLine("\t2. Eternal Goal");
        Console.WriteLine("\t3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string goalInput = Console.ReadLine();

        if (goalInput == "1")
                {
                    Console.WriteLine();
                    Console.Write("What is the name of your goal? ");
                    string goalName = Console.ReadLine();

                    Console.WriteLine();
                    Console.Write("What is a short description of it? ");
                    string goalDescription = Console.ReadLine();

                    Console.WriteLine();
                    Console.Write("What is the amount of points associated with this goal? ");
                    string goalPoints = Console.ReadLine();
                    int intGoalPoints = int.Parse(goalPoints);

                    SimpleGoal simpleGoal = new SimpleGoal(goalName, goalDescription, intGoalPoints);
                    _goals.Add(simpleGoal);
                }
        else if (goalInput == "2")
                {
                    Console.WriteLine();
                    Console.Write("What is the name of your goal? ");
                    string goalName = Console.ReadLine();

                    Console.WriteLine();
                    Console.Write("What is a short description of it? ");
                    string goalDescription = Console.ReadLine();

                    Console.WriteLine();
                    Console.Write("What is the amount of points associated with this goal? ");
                    string goalPoints = Console.ReadLine();
                    int intGoalPoints = int.Parse(goalPoints);

                    EternalGoal eternalGoal = new EternalGoal(goalName, goalDescription, intGoalPoints);
                    _goals.Add(eternalGoal);
                }
        else if (goalInput == "3")
                {
                    Console.WriteLine();
                    Console.Write("What is the name of your goal? ");
                    string goalName = Console.ReadLine();

                    Console.WriteLine();
                    Console.Write("What is a short description of it? ");
                    string goalDescription = Console.ReadLine();

                    Console.WriteLine();
                    Console.Write("What is the amount of points associated with this goal? ");
                    string goalPoints = Console.ReadLine();
                    int intGoalPoints = int.Parse(goalPoints);

                    Console.WriteLine();
                    Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                    string goalAmount = Console.ReadLine();
                    int intGoalAmount = int.Parse(goalAmount);

                    Console.WriteLine();
                    Console.Write($"What is the bonus for accomplishing it {goalAmount} times? ");
                    string goalBonus = Console.ReadLine();
                    int intGoalBonus = int.Parse(goalBonus);

                    ChecklistGoal checklistGoal = new ChecklistGoal(goalName, goalDescription, intGoalPoints, intGoalAmount, intGoalBonus);
                    _goals.Add(checklistGoal);
                }
        else
                {
                    Console.WriteLine("You have chosen an invalid input, please type a number to one of the options listed.");
                }
    }
    // CreateGoal - Asks the user for the information about a new goal. Then, creates the goal and adds it to the list.

    public void RecordEvent()
    {
        Console.WriteLine("The goals are:");
        ListGoalNames();
        Console.Write("Which goal did you accomplish? ");
        string stringInput = Console.ReadLine();
        int intInput = int.Parse(stringInput);
        intInput --;

        Goal goal = _goals[intInput];
        int scoreAdd = goal.RecordEvent();
        _score += scoreAdd;

        Console.WriteLine();
        Console.WriteLine($"Congratulations! You have earned {scoreAdd} points!");
        Console.WriteLine($"You now have {_score} points.");
    }
    // RecordEvent - Asks the user which goal they have done and then records the event by calling the RecordEvent method on that goal.

    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(_score);
            outputFile.WriteLine(_level);
            outputFile.WriteLine(_scoreNeeded);
            foreach (Goal g in _goals)
            {
                outputFile.WriteLine(g.GetStringRepresentation());
            }
        }
    }
    // SaveGoals - Saves the list of goals to a file.

    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(fileName);

        string stringScore = lines[0];
        int score = int.Parse(stringScore);
        _score = score;

        string stringLevel = lines[1];
        int level = int.Parse(stringLevel);
        _level = level;

        string stringScoreNeeded = lines[2];
        int scoreNeeded = int.Parse(stringScoreNeeded);
        _scoreNeeded = scoreNeeded;

        var skippedList = lines.Skip(3).ToList();

        foreach (string line in skippedList)
        {
            string[] parts = line.Split(":");
            string className = parts[0];
            string inputInfo = parts[1];

            string[] classParts = inputInfo.Split(",");
             string name = classParts[0];
            string description = classParts[1];
                
            string strPoints = classParts[2];
            int points = int.Parse(strPoints);

            if (className == "SimpleGoal")
            {
                SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
                _goals.Add(simpleGoal);

                string isComplete = classParts[3];
                bool boolIsComplete = bool.Parse(isComplete);
                if (boolIsComplete == true)
                {
                    simpleGoal.RecordEvent();
                }
                
            }

            else if (className == "ChecklistGoal")
            {
                string strBonus = classParts[3];
                int bonus = int.Parse(strBonus);

                string strTotal = classParts[4];
                int total = int.Parse(strTotal);
                ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, bonus, total);
                _goals.Add(checklistGoal);

                string strAmount = classParts[5];
                int amount = int.Parse(strAmount);

                int i = 0;

                while (i < amount)
                {
                    checklistGoal.RecordEvent();
                    i ++;
                }
            }

            else if (className == "EternalGoal")
            {
                EternalGoal eternalGoal = new EternalGoal(name, description, points);
                _goals.Add(eternalGoal);
            }
        }
    }
    // LoadGoals - Loads the list of goals from a file.
}