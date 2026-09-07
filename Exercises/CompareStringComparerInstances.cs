namespace P02.Exercises;

public static class CompareStringComparerInstances
{
    public static void Run()
    {
        CompareStringComparerReferences();


    }
    private static void CompareStringComparerReferences()
    {
        StringComparer stringComparer1, stringComparer2;
        stringComparer1 = StringComparer.CurrentCultureIgnoreCase;
        stringComparer2 = StringComparer.CurrentCultureIgnoreCase;
        // Displays false
        Console.WriteLine(StringComparer.ReferenceEquals(stringComparer1,
                                                         stringComparer2));
    }
}
