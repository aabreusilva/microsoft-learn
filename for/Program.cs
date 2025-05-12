using System;

for (int i = 0; i <= 10; i++)
{
    Console.WriteLine(i);
}

Console.WriteLine("-------------");

//reverse
for (int j = 10; j >= 0; j--)
{
    Console.WriteLine(j);
}

Console.WriteLine("--------------");

//break in number seven.
for (int k = 0; k <= 10; k++)
{
    Console.WriteLine(k);
    if (k == 7) break;
}

Console.WriteLine("---------------");

//loop through each element of an array.
string[] names = { "Alex", "Eddie", "Michael", "David" };
for (int l = names.Length - 1; l >= 0; l--)
{
    Console.WriteLine(names[l]);
}

Console.WriteLine("---------------");

//string[] names1 = {"Alex", "Eddie", "Michael", "David"};
//foreach (var name in names1)
//{
//if (name == "David") 
//name = "Sammy"; Não é possível atribuir o valor de name por que ele faz parte da implementação interna da iteração FOREACH.
//}

//Superando a limitação da instrução foreach usando a instrução for:

string[] names1 = { "Alex", "Eddie", "Michael", "David" };
for (int m = 0; m < names1.Length; m++)
    if (names1[m] == "David") names1[m] = "Sammy";

foreach (var name in names1) Console.WriteLine(name);