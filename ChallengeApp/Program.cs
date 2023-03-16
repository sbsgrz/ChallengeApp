using ChallengeApp;

Console.WriteLine("Witam w aplikacji ChallengeApp. Podaj oceny pracownika (q - kończy wprowadzanie)");

var emploee = new Emploee();

var list = new List<string> { "A", "a", "B", "b", "C", "c", "D", "d", "E", "e" };

while (true)
{
    Console.WriteLine("Podaj wartość");
    var grade = Console.ReadLine();
    
    if(grade == "q")
    {
        break;
    }

    if (list.Contains(grade))
        emploee.AddGrade(grade[0]);
    else
        emploee.AddGrade(grade);
}

Statistics emploeeStatistics = new Statistics();
emploeeStatistics = emploee.GetStatistics();

Console.WriteLine("Statystyki:");
Console.WriteLine($"Min:    {emploeeStatistics.Min}");
Console.WriteLine($"Max:    {emploeeStatistics.Max}");
Console.WriteLine($"Sum:    {emploeeStatistics.Sum}");
Console.WriteLine($"Avg:    {emploeeStatistics.Average:N2}");
Console.WriteLine($"AvgL:   {emploeeStatistics.AverageLetter}");



// Dzień 12 -
// 1) średnia w formie char
// 2) wprowadzanie danych przez użytkownika
// 3) Testy
/*
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
*/