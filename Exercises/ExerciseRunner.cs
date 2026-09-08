namespace P02.Exercises;

public static class ExerciseRunner
{
    private static readonly Dictionary<ExerciseName, Action> Exercises = new()
    {
        { ExerciseName.ConsoleInputExercises, ConsoleInputExercises.Run },
        { ExerciseName.CompareStringComparerInstances, CompareStringComparerInstances.Run },
        { ExerciseName.PrintTwoDimensionalArray, PrintTwoDimensionalArray.Run },
        { ExerciseName.WorkWithOneDimensionalArrays, WorkWithOneDimensionalArrays.Run },
        { ExerciseName.Exercise5,Exercise5.Run },
        { ExerciseName.Exercise6,Exercise6.Run },
        { ExerciseName.Exercise7, Exercise7.Run }
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
