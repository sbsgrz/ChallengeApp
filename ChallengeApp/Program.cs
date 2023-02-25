
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

Console.ReadLine();
