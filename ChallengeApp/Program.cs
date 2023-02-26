// maksymalna liczba z 3

int ilosc = 3;
int[] tab = new int[ilosc];
int max;
int ilosc_max = 1;


Console.WriteLine("Podaj pierwszą liczbę");
tab[0] = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Podaj drugą liczbę");
tab[1] = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Podaj trzecią liczbę");
tab[2] = Convert.ToInt32(Console.ReadLine());

max = tab[0];
for (int i = 1; i < ilosc; i++)
    if (tab[i] > max)
    {
        max = tab[i];
        ilosc_max = 1;
    }
    else if (tab[i] == max)
    {
        ilosc_max++;
    }


Console.WriteLine("Maksymalna liczba to: " + max + ". Jest " + ilosc_max + " takich liczb.");

Console.ReadLine();


