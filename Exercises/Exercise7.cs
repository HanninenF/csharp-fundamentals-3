namespace P02.Exercises;
/* 3. CalculateTax()
Skriv en metod som heter CalculateTax som:

Tar en decimal som parameter, den kan heta amount.
Returnerar en decimal som är 30% av amount.
Skriv ett litet program som ber användaren skriva in sin inkomst, anropar CalculateTax med inkomsten och skriver ut siffran som metoder skickar tillbaka. */
public static class Exercise7
{
    public static void Run()
    {
        const bool calculateTax = true;
        switch (true)
        {
            case calculateTax:
                Console.WriteLine("Please enter your income:");
                string? incomeFromUser = Console.ReadLine();

                if (incomeFromUser != null)
                {
                    decimal income = decimal.Parse(incomeFromUser);
                    decimal amount = CalculateTax(income);
                    Console.WriteLine(amount);
                }
                break;
            default: return;
        }
    }

    static private decimal CalculateTax(decimal amount)
    {
        decimal thirtyPercentOfAmount = amount * 0.3m;

        return thirtyPercentOfAmount;
    }
}
