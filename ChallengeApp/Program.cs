// maksymalna liczba z 3

int ilosc = 3;
List<int> list = new List<int>();
int max;
int ilosc_max = 0;

Console.WriteLine("Podaj pierwszą liczbę");
list.Add(Convert.ToInt32(Console.ReadLine()));

Console.WriteLine("Podaj drugą liczbę");
list.Add(Convert.ToInt32(Console.ReadLine()));

Console.WriteLine("Podaj trzecią liczbę");
list.Add(Convert.ToInt32(Console.ReadLine()));

max = list.Max();

foreach (int i in list)
    if (list[i] == max)
        ilosc_max++;

Console.WriteLine("Maksymalna liczba to: " + list.Max() + ". Jest " + ilosc_max + " takich liczb.");


Console.ReadLine();


