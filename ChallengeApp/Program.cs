// Klasy dzień 6
using ChallengeApp;

var emploee = new Emploee("Jan", "Kowalski", 35);

Random r = new();
int grade;

for (int i = 0; i < 10; i++)
{
    grade = r.Next(100);

    if (emploee.AddGrade(grade))
    {
        Console.WriteLine($"Dodano {grade} punktów pracownikowi: {emploee.FirstName} {emploee.LastName}");
    }
    else if (!emploee.AddGrade(grade))
    {
        Console.WriteLine($"Pracownik {emploee.FirstName} {emploee.LastName} funkcja AddGrade - podana wartość nie spełnia założeń");
    }
}

List<Statistics> stats = new List<Statistics>();
stats.Add(emploee.GetStatisticsWithForEach());
stats.Add(emploee.GetStatisticsWithFor());
stats.Add(emploee.GetStatisticsWithDoWhile());
stats.Add(emploee.GetStatisticsWithWhile());

