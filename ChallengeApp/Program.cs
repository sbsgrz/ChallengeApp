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

Console.ReadLine();