using ChallengeApp;


var emploeeIF = new Emploee();

try
{
    emploeeIF.AddGrade(2.35F);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

/*var emploee = new Emploee();
var supervisor = new Supervisor();

Console.WriteLine("Witam w aplikacji ChallengeApp. Podaj oceny PRACOWNIKA (q - kończy wprowadzanie)");

while (true)
{
    Console.WriteLine("Podaj wartość");
    var input = Console.ReadLine();

    if (input == "q")
    {
        break;
    }

    try
    {
        emploee.AddGrade(input);
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}


Console.WriteLine("\n\nPodaj oceny PRZEŁOŻONEGO (q - kończy wprowadzanie)");

while (true)
{
    Console.WriteLine("Podaj wartość");
    var input = Console.ReadLine();

    if (input == "q")
    {
        break;
    }

    try
    {
        supervisor.AddGrade(input);
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}



Statistics emploeeStatistics = new Statistics();
emploeeStatistics = emploee.GetStatistics();

Statistics supervisorStatistics = new Statistics();
supervisorStatistics = supervisor.GetStatistics();

Console.WriteLine("Statystyki - PRACOWNIK:");
Console.WriteLine($"Min:    {emploeeStatistics.Min}");
Console.WriteLine($"Max:    {emploeeStatistics.Max}");
Console.WriteLine($"Sum:    {emploeeStatistics.Sum}");
Console.WriteLine($"Avg:    {emploeeStatistics.Average:N2}");
Console.WriteLine($"AvgL:   {emploeeStatistics.AverageLetter}");


Console.WriteLine("\n\nStatystyki - PRZEŁOŻONY:");
Console.WriteLine($"Min:    {supervisorStatistics.Min}");
Console.WriteLine($"Max:    {supervisorStatistics.Max}");
Console.WriteLine($"Sum:    {supervisorStatistics.Sum}");
Console.WriteLine($"Avg:    {supervisorStatistics.Average:N2}");
Console.WriteLine($"AvgL:   {supervisorStatistics.AverageLetter}");

Console.ReadLine();*/