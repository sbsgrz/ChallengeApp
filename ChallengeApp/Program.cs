// konwersja dni na lata, tygodnie i dni

int days = 0, years = 0, weeks = 0;

Console.WriteLine("Podaj liczbę dni.");
days = int.Parse(Console.ReadLine());

years = days / 365;
days = days % 365;
weeks = days / 7;
days = days % 7;


Console.WriteLine("W przeliczeniu na lata i tygodnie: " + years + " lat, " + weeks + " tygodni, " + days + " dni.");



