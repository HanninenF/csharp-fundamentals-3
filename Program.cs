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
using P02.Exercises;
namespace P02;


static class Program
{
    public static void Main()
    {
        ExerciseRunner.Run(ExerciseName.ConsoleInputExercises);
    }
}
