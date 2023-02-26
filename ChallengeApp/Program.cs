// Dni tygodnia

string[] daysOfWeek = new string[] { "poniedziałek", "wtorek", "środa","czwartek","piątek","sobota","niedziela" };
int day = 0;

do {
    
    Console.WriteLine("\nKtóry dzień tygodnia Cię interesuje? (0 - koniec programu)");
    day = int.Parse(Console.ReadLine());

    if (day > 0 && day < 8)
        Console.WriteLine(daysOfWeek[day - 1]);
    else if (day != 0)
        Console.WriteLine("Wartość nieprawidłowa!!!");
    else
    {
        Console.WriteLine("Koniec programu!");
        Console.ReadLine();
    }
} while (day != 0) ;








