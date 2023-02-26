// maksymalna liczba z 3

int[] tab = new int[3];
int max = 0;


Console.WriteLine("Podaj pierwszą liczbę");
tab[0] = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Podaj drugą liczbę");
tab[1] = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Podaj trzecią liczbę");
tab[2] = Convert.ToInt32(Console.ReadLine());

if (tab[0] > tab[1])
{
    if (tab[0] > tab[2])
        Console.WriteLine("Największa jest liczba " + tab[0]);
    else if (tab[2] > tab[0])
        Console.WriteLine("Największa jest liczba " + tab[2]);
    else
        Console.WriteLine("Liczby 1 i 3 (" + tab[0] + ") są największe i równe.");
}
else if (tab[1] > tab[0])
{
    if (tab[1] > tab[2])
        Console.WriteLine("Największa jest liczba " + tab[1]);
    else if (tab[2] > tab[1])
        Console.WriteLine("Największa jest liczba " + tab[2]);
    else
        Console.WriteLine("Liczby 2 i 3 (" + tab[1] + " są największe i równe.");
}
else if (tab[0] > tab[2])
{
    Console.WriteLine("Liczby 1 i 2 (" + tab[0] + ") są największe i równe.");
}
else if (tab[2] > tab[0])
{
    Console.WriteLine("Największa jest liczba " + tab[2]);
}
else
{
    Console.WriteLine("Wszystkie liczby są równe");
}