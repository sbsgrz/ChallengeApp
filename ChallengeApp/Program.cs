int number = 0;
int[] rejestr  = new int[10];

for (int i = 0; i < 10; i++)
    rejestr[i] = 0;

Console.WriteLine("Podaj liczbę");
number = Convert.ToInt32(Console.ReadLine());

while(number > 0)
{
    rejestr[number % 10]++;
    number /= 10;
}

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i + " => " + rejestr[i]);
}

Console.ReadLine();