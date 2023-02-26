// max, min, avg

List<int> list = new List<int>();

Console.WriteLine("Podaj 9 liczb. Zatwierdź enterem każdą z nich");

for(int i=0; i<9; i++)
{
    list.Add(int.Parse(Console.ReadLine()));
}

Console.WriteLine("Max: " + list.Max());
Console.WriteLine("Min: " + list.Min());
Console.WriteLine("Avg: " + list.Average());

Console.ReadLine();
