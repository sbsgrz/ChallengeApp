using ChallengeApp;

Console.WriteLine("Witam w aplikacji ChallengeApp. Podaj oceny pracownika (q - kończy wprowadzanie)");

var emploee = new Emploee();

while (true)
{
    Console.WriteLine("Podaj wartość");
    var input = Console.ReadLine();
    
    if(input == "q")
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

Statistics emploeeStatistics = new Statistics();
emploeeStatistics = emploee.GetStatistics();

Console.WriteLine("Statystyki:");
Console.WriteLine($"Min:    {emploeeStatistics.Min}");
Console.WriteLine($"Max:    {emploeeStatistics.Max}");
Console.WriteLine($"Sum:    {emploeeStatistics.Sum}");
Console.WriteLine($"Avg:    {emploeeStatistics.Average:N2}");
Console.WriteLine($"AvgL:   {emploeeStatistics.AverageLetter}");

Console.ReadLine();