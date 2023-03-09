﻿// Klasy dzień 6
using ChallengeApp;

var e1 = new Emploee("Jan", "Kowalski", 35);
var e2 = new Emploee("Robert", "Ćwiąkalski", 41);
var e3 = new Emploee("Julita", "Dąbrowska", 39);

List<Emploee> listEmploee = new(){ e1, e2, e3};


Random r = new();
int grade;
foreach (var e in listEmploee)
{
    for (int i = 0; i < 10; i++)
    {
        grade = r.Next(100);
        
        if(i % 10 == 0)
            grade = -grade;

        if(e.AddGrades(grade))
        {
            Console.WriteLine($"Dodano {grade} punktów pracownikowi: {e.FirstName} {e.LastName}");
        }
        else if(!e.AddGrades(grade))
        {
            // Console.WriteLine("BŁĄD!!! Próbujesz dodać liczbę ujemną - użyj funkcji Removegrade()!");
            Console.WriteLine($"Pracownik {e.FirstName} {e.LastName} funkcja AddGrade - podana wartość jest poza skalą");
        }

        /*
            if(e.Removegrade(grade))
            {
                Console.WriteLine("Odjęto " + grade + " punktów pracownikowi: " + e.FirstName + " " + e.LastName);
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
    Console.WriteLine(e.FirstName+ " " + e.LastName + " - grade: " + e.GetStatistics().Sum);
    if (e.GetStatistics().Sum > theWinner.GetStatistics().Sum)
        theWinner = e;
}
Console.WriteLine();
Console.WriteLine("And the winner is: " + theWinner.FirstName + " " + theWinner.LastName + " - grade: " + theWinner.GetStatistics().Sum);

/*
char
sbyte
byte
short
ushort
int
uint
long
ulong
decimal
double
float 
*/

char gradeChar = '1';
sbyte gradeSbyte = 1;
byte gradeByte = 1;
short gradeShort = 1;
ushort gradeUshort = 1;
int gradeInt = 1;
uint gradeUint = 1;
long gradeLong = 1;
<<<<<<< HEAD
ulong gradeUlong = 1;
=======
ulong gradeULong = 1;
>>>>>>> f5093d3f611308efb7e7c7c553876477fdbe64dc
decimal gradeDecimal = 1;
double gradeDouble = 1;

Emploee emploeeTesty = new Emploee();

Console.WriteLine("Testy różnych typów");
emploeeTesty.AddGrades(gradeChar);
emploeeTesty.AddGrades(gradeSbyte);
emploeeTesty.AddGrades(gradeByte);
emploeeTesty.AddGrades(gradeShort);
emploeeTesty.AddGrades(gradeUshort);
emploeeTesty.AddGrades(gradeInt);
<<<<<<< HEAD
emploeeTesty.AddGrades(gradeUint);
emploeeTesty.AddGrades(gradeLong);
emploeeTesty.AddGrades(gradeUlong);
emploeeTesty.AddGrades(gradeDecimal);
emploeeTesty.AddGrades(gradeDouble);
=======

>>>>>>> f5093d3f611308efb7e7c7c553876477fdbe64dc
