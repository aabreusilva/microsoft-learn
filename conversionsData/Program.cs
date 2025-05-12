//Escreva um código que tente somar um int com uma string e salve o resultado em um int.
int first = 2;
string second = "4";
string result = first + second;
Console.WriteLine(result);

Console.WriteLine();

//Tenta alterar o tipo de dados do valor resultaria em uma perda de informações?
//Conversão de extensão.
int myInt = 3;
Console.WriteLine($"int: {myInt}");

decimal myDecimal0 = myInt;
Console.WriteLine($"decimal: {myDecimal0}");

Console.WriteLine();

//Executar uma coerção.
decimal  myDecimal1 = 3.14m;
Console.WriteLine($"decimal: {myDecimal1}");

int myInt1 = (int)myDecimal1;
Console.WriteLine($"int {myInt1}");

Console.WriteLine();

//Determine se a conversão é uma "conversão de expansão" ou uma "conversão de restrição".
decimal myDecimal2 = 1.23456789m;
float myFloat = (float)myDecimal2;

Console.WriteLine($"Decimal: {myDecimal2}");
Console.WriteLine($"Float: {myFloat}"); //Conversão de restrição, pois há perda de precisão do valor.

Console.WriteLine();

//Usando ToString() para converter um número em um string.
int first1 = 5;
int second1 = 7;
string message = first1.ToString() + second1.ToString();
Console.WriteLine(message);

Console.WriteLine();

//Converter um string em um int usando o método auxiliar Parse().
string first2 = "5";
string second2 = "7";
int sum = int.Parse(first2) + int.Parse(second2);
Console.WriteLine(sum);

Console.WriteLine();

//Converter um string em um int usando a classe Convert.
string value1 = "5";
string value2 = "7";
int result1 = Convert.ToInt32(value1) * Convert.ToInt32(value2);
Console.WriteLine(result1);

Console.WriteLine();

//Comparar a coerção e a conversão de um decimal em um int.
int value3 = (int)1.5m; //casting truncates.
Console.WriteLine(value3);

int value4 = Convert.ToInt32(1.5m); //Convert rounds up.
Console.WriteLine(value4);