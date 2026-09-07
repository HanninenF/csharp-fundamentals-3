namespace P02.Exercises;

public static class ExerciseRunner
{
    private static readonly Dictionary<ExerciseName, Action> Exercises = new()
    {
        { ExerciseName.Exercise1, Exercise.Run },
        { ExerciseName.Exercise2, Exercise2.Run },
        { ExerciseName.PrintTwoDimensionalArray, PrintTwoDimensionalArray.Run },
        { ExerciseName.Exercise4, Exercise4.Run }
    };

    public static void Run(ExerciseName exercise)
    {
        Exercises[exercise]();
    }

    public static void RunAll()
    {
        foreach (Action exercise in Exercises.Values)
        {
            exercise();
        }
    }
}