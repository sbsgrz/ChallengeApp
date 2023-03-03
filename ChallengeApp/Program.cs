// Klasy dzień 6
using ChallengeApp;

var e1 = new Emploee("Jan", "Kowalski", 35);
var e2 = new Emploee("Robert", "Ćwiąkalski", 41);
var e3 = new Emploee("Julita", "Dąbrowska", 39);

List<Emploee> listEmploee = new(){ e1, e2, e3};


Random r = new();
int score;
foreach (var e in listEmploee)
{
    for (int i = 0; i < 10; i++)
    {
        score = r.Next(50);
        if(i % 10 == 0)
        {
            score = -score;
        }
        
        if(r.Next(2) == 1)
        { 
            if(e.AddScore(score))
            {
                Console.WriteLine("Dodano " + score + " punktów pracownikowi: " + e.FirstName + " " + e.LastName);
            }
            else if(!e.AddScore(score))
            {
                Console.WriteLine("BŁĄD!!! Próbujesz dodać liczbę ujemną - użyj funkcji RemoveScore()!");
            }
        }
        else
        {
            if(e.RemoveScore(score))
            {
                Console.WriteLine("Odjęto " + score + " punktów pracownikowi: " + e.FirstName + " " + e.LastName);
            }
            else
            {
                Console.WriteLine("NIEOBSŁUGIWANY BŁĄD!!!");
            }
        }
    }
}


var theWinner = new Emploee();

foreach(var e in listEmploee)
{
    Console.WriteLine(e.FirstName+ " " + e.LastName + " - score: " + e.result);
    if (e.result > theWinner.result)
        theWinner = e;
}
Console.WriteLine();
Console.WriteLine("And the winner is: " + theWinner.FirstName + " " + theWinner.LastName + " - score: " + theWinner.result);

/*
User user1= new User();
User user2= new User("Anna","ddffssaa");

user1.AddScore(10);
user1.AddScore(5);
user1.AddScore(15);
user1.AddScore(20);
user1.AddScore(5);

user2.AddScore(20);
user2.AddScore(10);
user2.AddScore(25);

var result1 = user1.Result;
var result2 = user2.Result;
*/