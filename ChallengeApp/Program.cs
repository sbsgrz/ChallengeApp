using ChallengeApp;


var emploeeIF = new EmploeeInFile();
var emploeeIM = new EmploeeInMemory();


void EmploeeGradeAdded(object sender, EventArgs args)
{
    Console.WriteLine($"New rating has been added: {sender.ToString()}");
    
}

emploeeIF.GradeAdded += EmploeeGradeAdded;
emploeeIM.GradeAdded += EmploeeGradeAdded;

Console.WriteLine("Hello! Provide emploee evaluations (q - finishes entering)");

while (true)
{
    Console.WriteLine("Enter a value");
    var input = Console.ReadLine();

    if (input == "q")
    {
        break;
    }

    try
    {
        emploeeIF.AddGrade(input);
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }

    try
    {
        emploeeIM.AddGrade(input);
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}

Statistics emploeeIFStatistics = new Statistics();
emploeeIFStatistics = emploeeIF.GetStatistics();

Statistics emploeeIMStatistics = new Statistics();
emploeeIMStatistics = emploeeIM.GetStatistics();

Console.WriteLine("Emploee statistics (IF):");
Console.WriteLine($"Min:    {emploeeIFStatistics.Min}");
Console.WriteLine($"Max:    {emploeeIFStatistics.Max}");
Console.WriteLine($"Sum:    {emploeeIFStatistics.Sum}");
Console.WriteLine($"Avg:    {emploeeIFStatistics.Average:N2}");
Console.WriteLine($"AvgL:   {emploeeIFStatistics.AverageLetter}");

Console.WriteLine("Emploee statistics (IM):");
Console.WriteLine($"Min:    {emploeeIMStatistics.Min}");
Console.WriteLine($"Max:    {emploeeIMStatistics.Max}");
Console.WriteLine($"Sum:    {emploeeIMStatistics.Sum}");
Console.WriteLine($"Avg:    {emploeeIMStatistics.Average:N2}");
Console.WriteLine($"AvgL:   {emploeeIMStatistics.AverageLetter}");


Console.ReadLine();




/*
try
{
    emploeeIF.AddGrade(2.35F);
    emploeeIF.AddGrade('A');
    emploeeIF.AddGrade('B');
    emploeeIF.AddGrade(2.35D);
    emploeeIF.AddGrade(2.35D);

    emploeeIM.AddGrade(2.35F);
    emploeeIM.AddGrade('A');
    emploeeIM.AddGrade('B');
    emploeeIM.AddGrade(2.35D);
    emploeeIM.AddGrade(2.35D);

    emploeeIF.AddGrade('2');
    emploeeIF.AddGrade("2.35");


}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
finally
{
    result = emploeeIF.GetStatistics();
}

Console.WriteLine($"Results: Min: {result.Min}, Max: {result.Max}, Sum: {result.Sum} Avg: {result.Average}, AvgLetter: {result.AverageLetter}");
*/