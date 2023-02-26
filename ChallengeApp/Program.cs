int number = 0;
string numberInString;
char[] letters;
int[] rejestr  = new int[10];

for (int i = 0; i < 10; i++)
    rejestr[i] = 0;

Console.WriteLine("Podaj liczbę");
number = Convert.ToInt32(Console.ReadLine());

numberInString = number.ToString();
letters = numberInString.ToArray(); 


foreach(var c in letters)
{
    if (c == '0')
        rejestr[0]++;
    else if (c == '1')
        rejestr[1]++;
    else if (c == '2')
        rejestr[2]++;
    else if (c == '3')
        rejestr[3]++;
    else if (c == '4')
        rejestr[4]++;
    else if (c == '5')
        rejestr[5]++;
    else if (c == '6')
        rejestr[6]++;
    else if (c == '7')
        rejestr[7]++;
    else if (c == '8')
        rejestr[8]++;
    else if (c == '9')
        rejestr[9]++;
}

for(int i=0; i< 10; i++)
{
    Console.WriteLine(i + " => " + rejestr[i]);
}

Console.ReadLine(); 