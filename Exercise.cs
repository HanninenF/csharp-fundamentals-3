namespace P02;

public static class Exercise
{
    public static void Run()
    {
        bool twoInts = false;
        bool printUserWordUntilStopWord = true;
        bool genomgång = false;
        bool sumNumbersUntilStop = false;

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

        if (sumNumbersUntilStop)
        {
            SumNumbersUntilStop();
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

    public static void SumNumbersUntilStop()
    {
        int sum = 0;
        string stopWord = "sluta";
        while (true)
        {
            string? input = Console.ReadLine();


            if (!string.IsNullOrWhiteSpace(input) && StringComparer.CurrentCultureIgnoreCase.Equals(input, stopWord))

            {
                break;
            }
            else if (input == string.Empty)
            {
                Console.WriteLine("Du måste mata in något!");

            }
            else if (int.TryParse(input, out int number))
            {
                sum += number;
            }
            else
            {
                Console.WriteLine("Det där var inte ett giltigt tal!");
            }

        }
        Console.WriteLine($"Summan av talen är: {sum}");
    }
}
