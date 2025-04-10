Console.WriteLine("Signated integral types: ");

Console.WriteLine($"sbyte  :  {sbyte.MinValue} to {sbyte.MaxValue}");
Console.WriteLine($"short  :  {short.MinValue} to {short.MaxValue}");
Console.WriteLine($"int    :  {int.MinValue} to {int.MaxValue}");
Console.WriteLine($"long   :  {long.MinValue} to {long.MaxValue}");

Console.WriteLine("");

Console.WriteLine("Unsigned integral types: ");
Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
Console.WriteLine($"ulong  : {ulong.MinValue} to {uint.MaxValue}");

Console.WriteLine("");

Console.WriteLine("Floating point types: ");
Console.WriteLine($"floating   : {float.MinValue} to {float.MaxValue}"); //(Com ~6-9 digitos de percisão.)
Console.WriteLine($"double     : {double.MinValue} to {double.MaxValue}"); //(Com ~15-17 digitos de percisão.)
Console.WriteLine($"decimal    : {decimal.MinValue} to {decimal.MaxValue}"); //(Com ~28-29 digitos de percisão.)

Console.WriteLine();

//Definindo uma variável de tipo de referencia.
int[] data = new int[3];

string shortenedstring = "Hello World!";
Console.WriteLine(shortenedstring);

//Preocupações práticas usando valores de referência.
int val_A = 2;
int val_B = val_A;
val_B = 5;

Console.WriteLine("--Value types--");
Console.WriteLine($"val_A: {val_A}");
Console.WriteLine($"val_B: {val_B}");

Console.WriteLine();

//Tipos de referência em matriz.
int[] ref_A = new int[1];
ref_A[0] = 2;
int[] ref_B = ref_A;
ref_B[0] = 5;

Console.WriteLine("--Reference types--");
Console.WriteLine($"ref_A[0]: {ref_A[0]}");
Console.WriteLine($"ref_B[0]: {ref_B[0]}");