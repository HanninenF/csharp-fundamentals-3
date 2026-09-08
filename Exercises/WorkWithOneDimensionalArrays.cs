namespace P02.Exercises;

/* Arrayer
Deklarera en array med fem namn. Tilldela dem värden och skriv ut dem med hjälp av en loop (for eller while).
Skapa två arrayer, en med namn och en med åldrar. Skriv ut varje namn tillsammans med dess ålder.
Låt användaren mata in tre namn, lagra dem i en array och skriv sedan ut dem så att det ser ut så här:

Person 1: [namn]
Person 2: [namn]
Person 3: [namn] */
public static class WorkWithOneDimensionalArrays
{
    public static void Run()
    {
        bool requestNamesAndAgesAndPrint = true;
        if (requestNamesAndAgesAndPrint) RequestNamesAndAgesAndPrint();
    }

    private sealed class UserInput
    {
        public List<string> Names { get; } = [];
        public List<string> Ages { get; } = [];
    }
    public static void RequestNamesAndAgesAndPrint()
    {
        UserInput userInput = new();
        List<int> parsedAges = [];
        int counter = 3;

        for (int i = 0; i < counter; i++)
        {
            parsedAges.Add(UserPrompt(i, userInput));
        }

        PrintResult(parsedAges);
    }

    public static void PrintResult(List<int> parsedAges)
    {
        foreach (int age in parsedAges)
        {
            Console.WriteLine(age);
        }
    }

    private static int UserPrompt(int i, UserInput userInput)
    {

        List<string> userPrompts = ["Please enter a name:", "Please enter an age for "];

        Console.WriteLine(userPrompts[0]);
        userInput.Names.Add(Console.ReadLine() ?? "");
        Console.WriteLine(userPrompts[1] + userInput.Names[i]);
        userInput.Ages.Add(Console.ReadLine() ?? "");

        return int.Parse(userInput.Ages[i]);

    }
}
