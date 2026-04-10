

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public GoalManager()
    {
        _score = 0;
    }
        // IF CONFUSED ABOUT CODE MISSING, CHECK THE DROP DOWN ARROWS AND DON'T PANIC
    public void Start()
    {
        string input = "";

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

        while (input != "6")
        {
            if (input == "1")
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

                    SimpleGoal simpleGoal = new SimpleGoal(goalName, goalDescription, goalPoints);
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

                    EternalGoal eternalGoal = new EternalGoal(goalName, goalDescription, goalPoints);
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

                    Console.WriteLine();
                    Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                    string goalAmount = Console.ReadLine();
                    int intGoalAmount = int.Parse(goalAmount);

                    Console.WriteLine();
                    Console.Write($"What is the bonus for accomplishing it {goalAmount} of times? ");
                    string goalBonus = Console.ReadLine();
                    int intGoalBonus = int.Parse(goalBonus);

                    ChecklistGoal checklistGoal = new ChecklistGoal(goalName, goalDescription, goalPoints, intGoalAmount, intGoalBonus);
                    _goals.Add(checklistGoal);
                }
                else
                {
                    Console.WriteLine("You have chosen an invalid input, please type a number to one of the options listed.");
                }
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
                Console.Write("What is the filename for the goal file? ");
                string fileName = Console.ReadLine();
            }
            else if (input == "4")
            {
                Console.Write("What is the filename for the goal file? ");
                string fileName = Console.ReadLine();
            }
            else if (input == "5")
            {
                
            }
            else if (input == "6")
            {
                
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
        Console.WriteLine();
    }
    // DisplayPlayerInfo - Displays the players current score.

    public void ListGoalNames()
    {
        
    }
    // ListGoalNames - Lists the names of each of the goals.

    public void ListGoalDetails()
    {
        
    }
    // ListGoalDetails - Lists the details of each goal (including the checkbox of whether it is complete).

    public void CreateGoal()
    {
        
    }
    // CreateGoal - Asks the user for the information about a new goal. Then, creates the goal and adds it to the list.

    public void RecordEvent()
    {
        
    }
    // RecordEvent - Asks the user which goal they have done and then records the event by calling the RecordEvent method on that goal.

    public void SaveGoals()
    {
        
    }
    // SaveGoals - Saves the list of goals to a file.

    public void LoadGoals()
    {
        
    }
    // LoadGoals - Loads the list of goals from a file.
}