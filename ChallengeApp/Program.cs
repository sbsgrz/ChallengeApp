// odwrotność liczby

ulong number = 0;
ulong reverseNumber = 0;

Console.WriteLine("Podaj liczbę");
number = ulong.Parse(Console.ReadLine());

while(number > 0)
{
    reverseNumber = reverseNumber * 10 + (number % 10);
    number /= 10;
}

Console.WriteLine(reverseNumber);