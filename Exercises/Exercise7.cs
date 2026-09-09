namespace P02.Exercises;
/* 3. CalculateTax()
Skriv en metod som heter CalculateTax som:

Tar en decimal som parameter, den kan heta amount.
Returnerar en decimal som är 30% av amount.
Skriv ett litet program som ber användaren skriva in sin inkomst, anropar CalculateTax med inkomsten och skriver ut siffran som metoder skickar tillbaka. */

/* 1. WriteWarning()
Gör en metod som heter WriteWarning som:

Tar en sträng som parameter (den ska användas som meddelande).
Skriver ut meddelandet i konsolen med vit text på röd bakgrund.
Nollställer färgerna i konsolen efteråt.
Du kanske måste ta reda på hur färgen kan ändras i konsolen!

Gör sedan ett program som först skriver ut "Detta är ett vanligt meddelande", sedan anropar WriteWarning med meddelandet "Detta är ett varningsmeddelande" och slutligen skriver ut "Detta är ett annat vanligt meddelande". */

enum Exercise
{
    CalculateTax,
    WriteWarning,
    GetIntFromUserMax,
    GetIntFromUser,
    Genomgång,
    Genomgång2,
    Genomgång3,
    Genomgång4,
    File,
    File2

}

public static class Exercise7
{
    public static void Run()
    {
        Exercise exercise = Exercise.File;


        switch (exercise)
        {
            case Exercise.CalculateTax:
                Console.WriteLine("Please enter your income:");
                string? incomeFromUser = Console.ReadLine();

                if (incomeFromUser != null)
                {
                    decimal income = decimal.Parse(incomeFromUser);
                    decimal amount = CalculateTax(income);
                    Console.WriteLine(amount);
                }
                break;

            case Exercise.WriteWarning:
                string message = "Detta är ett vanligt meddelande";
                string warning = "Detta är ett varningsmeddelande";
                string anotherNormalMessage = "Detta är ett annat vanligt meddelande";

                WriteMessage(message);
                WriteWarning(warning);
                WriteMessage(anotherNormalMessage);
                break;

            case Exercise.GetIntFromUserMax:


                while (true)
                {
                    Console.WriteLine("mata in ett heltal");
                    string userInputString = Console.ReadLine() ?? "";
                    int resultat = GetIntFromUser(userInputString);
                    if (resultat != 0)
                    {
                        Console.WriteLine($" {resultat} ");
                    }

                    static int GetIntFromUser(string userInput)
                    {

                        if (int.TryParse(userInput, out int nummer))
                        {
                            int result = nummer;

                            return result;
                        }

                        else
                        {
                            Console.WriteLine("dedär var inte ett heltal");
                            return 0;
                        }

                    }

                }



                break;

            case Exercise.GetIntFromUser:
                /*             1. Parsningsmetod
                Skriv en metod som heter GetIntFromUser som:

                Tar en sträng som parameter (den ska användas som prompt när användaren ska mata in ett tal).
                Returnerar ett heltal som användaren matat in.
                (Svårare) Om användaren matar in något som inte är ett heltal, ska metoden skriva ut ett felmeddelande och fråga igen tills användaren matar in ett giltigt heltal. */


                string userPrompt = "Mata in ett tal";

                Console.WriteLine($"Du matade in:    {GetIntFromUser(userPrompt)}");
                break;

            case Exercise.Genomgång:
                //Ha en array med 5-10 olika meddelanden
                List<string> fortuneCookieMessages = ["Du får tur idag", "köp en hund", "Hej", "kass", "Du måste köpa mjölk"];

                //slumpa fram
                int randomNumber = Random.Shared.Next(0, fortuneCookieMessages.Count);

                //Skriv ett meddelande (indexering, noll-index)

                for (int i = 0; i <= fortuneCookieMessages.Count; i++)
                {
                    Console.WriteLine(fortuneCookieMessages[randomNumber]);
                    fortuneCookieMessages.Remove(fortuneCookieMessages[randomNumber]);
                }
                break;

            case Exercise.Genomgång2:
                //Läs in en textfil

                string[] lines = File.ReadAllLines("");

                //räkna hur många gånger order förekommer i filen
                string searchTerm = Console.ReadLine() ?? "";

                //räkna ut hur många gånger order förekommer if filen
                int wordCount = 0;

                foreach (string row in lines)
                {
                    string[] wordList = row.Split(" ");
                    foreach (string word in wordList)
                    {
                        if (searchTerm == word)
                        {

                            Console.WriteLine(row);
                            wordCount++;
                        }

                    }
                    //kolla om raden innehåller ordet

                }


                break;

            case Exercise.Genomgång3:

                int age = 10;
                DoubleNumber(age);

                Console.WriteLine(age);

                break;

            case Exercise.Genomgång4:

                List<string> importedNames = ["gun", "bob", "kim"];

                CensorNames(importedNames);

                foreach (string item in importedNames)
                {
                    Console.WriteLine(item);
                }


                break;

            case Exercise.File:
                string filePath = "exempel.txt";

                File.WriteAllText(filePath, "Detta är en exempeltext.");

                string content = File.ReadAllText(filePath);
                Console.WriteLine(content);

                string[] rowList = ["Första raden", "Andra raden", "Tredje raden"];
                File.WriteAllLines(filePath, rowList);

                string[] readLines = File.ReadAllLines(filePath);
                foreach (string line in readLines)
                {
                    Console.WriteLine(line);
                }

                string sourcePath = "exempel.txt";
                string destinationPath = "exempel_kopia.txt";

                File.Copy(sourcePath, destinationPath); // Kopiera filen

                bool fileExists = File.Exists(destinationPath); // Kolla om filen finns
                Console.WriteLine($"Filen finns: {fileExists}");

                File.Delete(destinationPath); // Ta bort filen

                break;
            case Exercise.File2:

                break;
            default: return;
        }
    }

    static private decimal CalculateTax(decimal amount)
    {
        decimal thirtyPercentOfAmount = amount * 0.3m;

        return thirtyPercentOfAmount;
    }
    static private void WriteWarning(string warning)
    {

        Console.ForegroundColor = ConsoleColor.White;
        Console.BackgroundColor = ConsoleColor.Red;
        Console.WriteLine(warning);
        Console.ResetColor();
    }

    static private void WriteMessage(string message)
    {
        Console.BackgroundColor = ConsoleColor.Green;
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine(message);
        Console.ResetColor();
    }

    static private int GetIntFromUser(string userPrompt)
    {
        Console.WriteLine(userPrompt);
        string? input = Console.ReadLine();
        int number = int.Parse(input ?? "");

        return number;
    }

    static public int DoubleNumber(int value)
    {
        value *= 2;
        return value;


    }

    static void CensorNames(List<string> names)
    {
        for (int i = 0; i < names.Count; i++)
        {
            if (names[i] == "gun") names[i] = "***";
        }
    }

}
