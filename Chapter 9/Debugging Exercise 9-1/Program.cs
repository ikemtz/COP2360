// Creates a HomeworkAssignment class
// instantiates two objects
// and prompts the user for infromation about two courses
using static System.Console;
class DebugNine1
{
    static void Main()
    {
        HomeworkAssignment course1 = new HomeworkAssignment();
        HomeworkAssignment course2 = new HomeworkAssignment();
  
        int exercises;

        // Get info for first class
        Write("What class do you have homework for? ");
        string entryString = ReadLine();
        course1.ClassName = entryString;
        Write("How many exercises must you complete? ");
        entryString = ReadLine();
        int.TryParse(entryString, out exercises);
        course1.NumberOfExercises = exercises;

        // Get info for another class
        Write("What class do you have homework for? ");
        entryString = ReadLine();
        course2.ClassName = entryString;
        Write("How many exercises must you complete? ");
        entryString = ReadLine();
        int.TryParse(entryString, out exercises);
        course2.NumberOfExercises = exercises;

        WriteLine("You have {0} minutes of homework for {1}",
              course1.TimeToComplete, course1.ClassName);
        WriteLine("and {0} more minutes for {1}",
              course2.TimeToComplete, course2.ClassName);
    }
}

public class HomeworkAssignment
{
    private int numberOfExercises;
    private int timeToComplete;
    // 10 minutes to complete each exercise
    private const int TIME_PER_EXERCISE = 10;


    public string ClassName { get; set; }

    public int NumberOfExercises
    {
        get
        {
            return numberOfExercises;
        }
        set
        {
            numberOfExercises = value;
            CalcCompletionTime();
        }
    }
    public double TimeToComplete
    {
        get
        {
            return timeToComplete;
        }
    }
    private void CalcCompletionTime()
    {
        timeToComplete = numberOfExercises * TIME_PER_EXERCISE;
    }
}