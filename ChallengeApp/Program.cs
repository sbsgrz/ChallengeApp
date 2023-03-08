// Klasy dzień 6
using ChallengeApp;

var e1 = new Emploee("Jan", "Kowalski", 35);
var e2 = new Emploee("Robert", "Ćwiąkalski", 41);
var e3 = new Emploee("Julita", "Dąbrowska", 39);

List<Emploee> listEmploee = new(){ e1, e2, e3};


Random r = new();
int grades;
foreach (var e in listEmploee)
{
    for (int i = 0; i < 10; i++)
    {
        grades = r.Next(100);
        
        if(i % 10 == 0)
            grades = -grades;

        if(e.AddGrades(grades))
        {
            Console.WriteLine($"Dodano {grades} punktów pracownikowi: {e.FirstName} {e.LastName}");
        }
        else if(!e.AddGrades(grades))
        {
            // Console.WriteLine("BŁĄD!!! Próbujesz dodać liczbę ujemną - użyj funkcji RemoveGrades()!");
            Console.WriteLine($"Pracownik {e.FirstName} {e.LastName} funkcja AddGrade - podana wartość jest poza skalą");
        }

        /*
            if(e.RemoveGrades(grades))
            {
                Console.WriteLine("Odjęto " + grades + " punktów pracownikowi: " + e.FirstName + " " + e.LastName);
            }
            else
            {
                Console.WriteLine("NIEOBSŁUGIWANY BŁĄD!!!");
            }
        */
    }
}


var theWinner = new Emploee();

foreach(var e in listEmploee)
{
    Console.WriteLine(e.FirstName+ " " + e.LastName + " - grades: " + e.GetStatistics().Sum);
    if (e.GetStatistics().Sum > theWinner.GetStatistics().Sum)
        theWinner = e;
}
Console.WriteLine();
Console.WriteLine("And the winner is: " + theWinner.FirstName + " " + theWinner.LastName + " - grades: " + theWinner.GetStatistics().Sum);