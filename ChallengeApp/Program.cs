// odwrotność liczby

int number = 0;
int reverseNumber = 0;

Console.WriteLine("Podaj liczbę");
number = int.Parse(Console.ReadLine());

while(number > 0)
{
    reverseNumber = reverseNumber * 10 + (number % 10);
    number /= 10;
}

Console.WriteLine(reverseNumber);