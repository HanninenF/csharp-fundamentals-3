/* SKAPA en variabel som heter INPUT och sätt den till "Hej"
LOOPA oändligt:
    SKRIV UT INPUT */

/*     IF INPUT är lika med "Hej"
    SKRIV UT "Du skrev Hej!"
ELSE
    SKRIV UT "Du skrev inte Hej!" */

/* Övning 03 Pseudokod
Övning 1
Tänk dig ett program som ber användaren mata in två tal, adderar dem och skriver ut resultatet:

Skriv pseudokod för programmet som kommentarer
Skriv koden för programmet i C# */

/* fråga användaren efter två tal
metod som adderar dem och returnerar
metod som printar resultatet */

/* Övning 2
Tänk dig ett program där användaren matar in ett ord. Ordet visas på skärmen och användaren får mata in ytterligare ett ord. Båda orden visas på skärmen osv. Detta fortsätter tills användaren matar in "sluta".

Skriv pseudokod för programmet som kommentarer
Skriv koden för programmet i C# */

/* string input variabel `word` 
print `word` i en LOOP */
namespace P02;

static class Program
{
    public static void Main()
    {
        bool twoInts = false;
        bool printUserWordUntilStopWord = true;

        if (twoInts)
        {
            int[] twoIntsFromUser = RequestFromUserTwoInts();
            PrintTwoIntsFromUser(twoIntsFromUser);
        }
        if (printUserWordUntilStopWord)
        {

            PrintUserWordUntilStopWord();
        }

    }

    public static int[] RequestFromUserTwoInts()
    {
        Console.WriteLine("Your task is two enter two ints. One at a time.\nPlease start with the first int:");
        string? inputFirstInt = Console.ReadLine();

        if (inputFirstInt != null)
        {
            int firstInt = int.Parse(inputFirstInt);
            Console.WriteLine("Please enter your second int:");

            string? inputSecondInt = Console.ReadLine();

            if (inputSecondInt != null)
            {
                int secondInt = int.Parse(inputSecondInt);

                return [firstInt, secondInt];
            }
            else return [];

        }
        else
        {
            return [];
        }
    }
    public static void PrintTwoIntsFromUser(int[] twoIntsFromUser)
    {
        for (int i = 0; i < twoIntsFromUser.Length; i++)
        {
            Console.WriteLine($"You have entererd: {twoIntsFromUser[i]}");
        }
    }

    public static void PrintUserWordUntilStopWord()
    {
        string word = "";
        string stopWord = "sluta";


        while (word != stopWord)
        {
            string? inputWord = Console.ReadLine();

            if (inputWord != null && inputWord != stopWord)
            {
                word = inputWord;
                Console.WriteLine($"Du skrev {inputWord}");
            }
            else if (inputWord == stopWord)
            {
                return;
            }
        }
    }
}