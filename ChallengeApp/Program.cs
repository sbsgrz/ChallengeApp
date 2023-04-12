using ChallengeApp;


var emploeeIF = new EmploeeInFile("Jan","Kowalski");
var emploeeIM = new EmploeeInMemory("Jan","Kowalski");


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

    if(input != null)
    { 
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
}

Statistics emploeeIFStatistics = new Statistics();
emploeeIFStatistics = emploeeIF.GetStatistics();

Statistics emploeeIMStatistics = new Statistics();
emploeeIMStatistics = emploeeIM.GetStatistics();

if (emploeeIFStatistics.Count > 0)
{
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
}
else
    Console.WriteLine("\nNO DATA ENTERED!!!");

Console.ReadLine();