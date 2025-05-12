using System;
void DisplayRandomNumbers()
{
    Random random = new Random();
    for (int i = 0; i < 5; i++)
    {
        Console.Write($"{random.Next(1, 100)} ");
    }
    Console.WriteLine();
}


void PrintArray()
{
    int[] a = { 1, 2, 3, 4, 5 };
    foreach (int x in a)
    {
        Console.Write($"{x} ");
    }
}

void SayHello()
{
    Console.WriteLine("Hello, World!");
}

Console.WriteLine("Generating random numbers:");
DisplayRandomNumbers();

Console.WriteLine("Say hello: ");
SayHello();

Console.WriteLine("Contents of arrays: ");
PrintArray();


//Recommended practices:
//Sempre deixar bem claro qual tarefa o método executa. Os nomes devem iniciar SEMPRE com a letra maiúscula e o restante minuscula(pascal style).
void ShowData(string a, int b, int c);
void DisplayDate(string month, int day, int year);