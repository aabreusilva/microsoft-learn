Random random = new Random();
int current = random.Next(1, 11);
while (current >= 3)
{
    Console.WriteLine(current);
    current = random.Next(1, 11);
}
Console.WriteLine($"Last number: {current}");

Console.WriteLine("------------------------------------------------");

//Usar a instrução continue para passar diretamente para uma expressão booleana.
Random random1 = new Random();
int current1 = random1.Next(1, 11);

do
{
    current1 = random1.Next(1, 11);
    if (current1 >= 8) continue;
    Console.WriteLine(current1);
}
while (current1 != 7);