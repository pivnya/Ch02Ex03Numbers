// See https://aka.ms/new-console-template for more information
WriteLine(("").PadRight(124, '-'));

WriteLine($"Type    {"Byte(s) of memory",-5} {"Min", 36} {"Max",48}");

WriteLine(("").PadRight(124, '-'));

WriteLine($"sbyte   {sizeof(sbyte), -5} {sbyte.MinValue, 48} {sbyte.MaxValue, 48}");
WriteLine($"byte    {sizeof(byte), -5} {byte.MinValue, 48} {byte.MaxValue, 48}");
WriteLine($"short   {sizeof(short), -5} {short.MinValue, 48} {short.MaxValue, 48}");
WriteLine($"ushort  {sizeof(ushort), -5} {ushort.MinValue, 48} {ushort.MaxValue, 48}");
WriteLine($"int     {sizeof(int), -5} {int.MinValue, 48} {int.MaxValue, 48}");
WriteLine($"uint    {sizeof(uint), -5} {uint.MinValue, 48} {uint.MaxValue, 48}");
WriteLine($"long    {sizeof(long), -5} {long.MinValue, 48} {long.MaxValue, 48}");
unsafe
{
    WriteLine($"Int128  {sizeof(Int128), -5} {Int128.MinValue, 48} {Int128.MaxValue, 48}");
    WriteLine($"UInt128 {sizeof(UInt128), -5} {UInt128.MinValue, 48} {UInt128.MaxValue, 48}");
    WriteLine($"Half    {sizeof(Half), -5} {Half.MinValue, 48} {Half.MaxValue, 48}");
}
WriteLine($"float   {sizeof(float), -5} {float.MinValue, 48} {float.MaxValue, 48}");
WriteLine($"double  {sizeof(double), -5} {double.MinValue, 48} {double.MaxValue, 48}");
WriteLine($"decimal {sizeof(decimal), -5} {decimal.MinValue, 48} {decimal.MaxValue, 48}");

WriteLine(("").PadRight(124, '-'));