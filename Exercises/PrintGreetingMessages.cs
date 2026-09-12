namespace P02.Exercises;
/* 1. PrintHello()
Skriv en enkel metod som skriver ut "Hello, World!" i konsolen. Anropa sedan metoden tre gånger på raken från din kod. Koden kan heta vad som helst, men tex kan den heta PrintHello. */

/* 2. WriteMessage()
Skriv en metod som heter WriteMessageTo som:

Tar en sträng som parameter, den kan heta name.
Skriver ut en sträng i stil med $"Hej {name}, hur mår du idag?" i konsolen. */




public static class PrintGreetingMessages
{
    public static void Run()
    {
        const bool printHello = false;
        const bool writeMessage = true;

        switch (true)
        {
            case printHello:
                for (int i = 0; i < 3; i++)
                {
                    PrintHello();
                }
                break;
            case writeMessage:
                {
                    string name = "Fredrik";
                    WriteMessage(name);
                    break;
                }

            default:
                return;
        }
    }

    static private void PrintHello()
    {
        string message = "Hello";
        Console.WriteLine(message);
    }

    static private void WriteMessage(string name)
    {
        Console.WriteLine($"Hej {name}, hur mår du idag?");
    }
}
