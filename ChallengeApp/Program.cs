
var varInt = int.MaxValue;
var varUInt = uint.MaxValue;

var varLong = long.MaxValue;
var varULong = ulong.MaxValue;

var varFloat = float.MaxValue;
var varDouble = double.MaxValue;

var varString = string.Empty;
varString = "Oto String";

Console.WriteLine("varInt = " + varInt);
Console.WriteLine("varUInt = " + varUInt);
Console.WriteLine("varLong = " + (long)varLong);
Console.WriteLine("varULong = " + varULong);
Console.WriteLine("varFloat = " + varFloat);
Console.WriteLine("varDouble = " + varDouble);
Console.WriteLine("varString = " + varString);
Console.WriteLine("String + Int: " + varString + varInt);

Console.ReadLine();
