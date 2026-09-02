namespace P02.Exercises;

public static class Exercise2
{
    public static void Run()
    {
        CompareCurrentCultureInsensitiveStringComparer();


    }
    private static void CompareCurrentCultureInsensitiveStringComparer()
    {
        StringComparer stringComparer1, stringComparer2;
        stringComparer1 = StringComparer.CurrentCultureIgnoreCase;
        stringComparer2 = StringComparer.CurrentCultureIgnoreCase;
        // Displays false
        Console.WriteLine(StringComparer.ReferenceEquals(stringComparer1,
                                                         stringComparer2));
    }
}