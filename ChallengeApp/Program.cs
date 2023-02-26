/*
var varInt = int.MaxValue;
var varUInt = uint.MaxValue;

var varLong = long.MaxValue;
var varULong = ulong.MaxValue;

var varFloat = float.MaxValue;
var varDouble = double.MaxValue;

var varString = string.Empty;
varString = "Oto String";

Console.WriteLine();
Console.WriteLine(" Max zmiennej varInt = " + varInt);
Console.WriteLine(" Max zmiennej varUInt = " + varUInt);
Console.WriteLine(" Max zmiennej varLong = " + (long)varLong);
Console.WriteLine(" Max zmiennej varULong = " + varULong);
Console.WriteLine(" Max zmiennej varFloat = " + varFloat);
Console.WriteLine(" Max zmiennej varDouble = " + varDouble);
Console.WriteLine(" Max zmiennej varString = " + varString);
Console.WriteLine(" Max zmiennej String + Int: " + varString + varInt);



if (varInt > varUInt)
{
    Console.WriteLine("varInt jest większa niż varUInt");
}
else
{
    Console.WriteLine("jednak varUInt jest większa niż varInt");
}
*/


// zadanie dzień 4
string firstName;
int age;
char sex;

Console.WriteLine("Podaj imię:");
firstName = Console.ReadLine();

Console.WriteLine("Podaj wiek");
age = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("Podaj płeć (k - kobieta, m - mężczyzna)");
sex = Console.ReadKey().KeyChar;
Console.WriteLine();

if (!(sex == 'k' || sex == 'm'))
{
    Console.WriteLine("Podałeś nieprawidłowe dane - KONIEC PROGRAMU!!!");
}
else if(age < 30 && sex == 'k')
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if(firstName == "Ewa" && age == 33)
{
    Console.WriteLine("Ewa lat 33");
}
else if(sex == 'm' && age < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}
else if(sex == 'k')
{
    Console.WriteLine(firstName + ", kobieta, lat " + age);
}
else if(sex == 'm')
{
    Console.WriteLine(firstName + ", mężczyzna, lat " + age);
}
else
{
    Console.WriteLine("Wprowadziłeś nieprawidłowe dane");
}





Console.ReadLine();
// ==
// <
// >
// <=
// >=

// && - and
// || - or
// !  - no fucking way


// dzień 5

// tablice
string[] daysOfWeek = { "poniedzialek", "wtorek", "środa", "czwartek", "piątek", "sobota", "niedziela" };


for(int i = 0;      i < 10; i++)
{
    Console.WriteLine(i);
}

// Listy
List<string> daysOfWeekList = new List<string>();
daysOfWeekList.Add("poniedziałek");
daysOfWeekList.Add("wtorek");
daysOfWeekList.Add("środa");
daysOfWeekList.Add("środa");
daysOfWeekList.Add("czwartek");
daysOfWeekList.Add("piątek");
daysOfWeekList.Add("sobota");
daysOfWeekList.Add("niedziela");

for(int i=0; i < daysOfWeekList.Count; i++)
{
    Console.WriteLine(daysOfWeekList[i]);
}

Console.ReadLine();

daysOfWeekList.Remove("środa");
ifdaysOfWeekList.Contains("czwartek");

foreach(string day in daysOfWeekList)
    Console.Write(day + " ");