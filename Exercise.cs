namespace P02;

public static class Exercise
{
    public static void Run()
    {
        bool twoInts = false;
        bool printUserWordUntilStopWord = false;
        bool genomgång = false;
        bool ex3 = true;

        if (twoInts)
        {
            int[] twoIntsFromUser = RequestFromUserTwoInts();
            PrintTwoIntsFromUser(twoIntsFromUser);
        }
        if (printUserWordUntilStopWord)
        {

            PrintUserWordUntilStopWord();
        }

        if (genomgång)
        {
            /*   string word = "en bra dag";
              string word2 = "abc";
              int comparedWord = String.Compare(word, word2);
              Console.WriteLine(comparedWord); */


        }

        if (ex3)
        {
            /*  Övning 3
 Skriv programmet för denna pseudokod:


 SKAPA en variabel som heter SUMMA och sätt den till 0
 LOOPA oändligt

     SKAPA en tom sträng som heter INPUT
     LÄS in en rad från användaren och spara i INPUT
     OM INPUT är lika med "sluta" (case insensitive)
         AVBRYT loopen
     ANNARS OM INPUT är tom
         SKRIV UT "Du måste mata in något!"
     ANNARS OM INPUT går att tolka som ett heltal
         ADDERA heltalet till SUMMA
     ANNARS
         SKRIV UT "Det där var inte ett giltigt tal!"
 SKRIV UT "Summan av talen är: " + SUMMA */

            int sum = 0;
            string stopWord = "sluta";
            while (sum == 0)
            {
                string? input = Console.ReadLine();


                if (!string.IsNullOrWhiteSpace(input) && StringComparer.CurrentCultureIgnoreCase.Equals(input, stopWord))

                {
                    break;
                }
                else if (input == string.Empty)
                {
                    Console.Write("Du måste mata in något!");
                }


            }

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