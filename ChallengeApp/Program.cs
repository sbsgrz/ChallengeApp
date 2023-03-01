// Klasy
using ChallengeApp;

var e1 = new Emploee("Jan", "Kowalski", 35);
var e2 = new Emploee("Robert", "Ćwiąkalski", 41);
var e3 = new Emploee("Julita", "Dąbrowska", 39);

List<Emploee> listEmploee = new List<Emploee>();
listEmploee.Add(e1);
listEmploee.Add(e2);
listEmploee.Add(e3);

Random r = new();

foreach (var e in listEmploee)
{
    for (int i = 0; i < 10; i++)
        e.AddScore(r.Next(50));
}

Emploee theWinner = new Emploee();

foreach(var e in listEmploee)
{
    Console.WriteLine(e.FirstName+ " " + e.LastName + " - score: " + e.result);
    if (e.result > theWinner.result)
        theWinner = e;
}

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