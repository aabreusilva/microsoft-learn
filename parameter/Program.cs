
/*Neste exemplo, o método CountTo aceita um parâmetro inteiro chamado max. O parâmetro é referenciado no for do loop
 *do método. Quando CountTo é chamado, o inteiro 5 é fornecido como argumento.*/

CountTo(5);

void CountTo(int max)
{
    for(int i = 0; i < max; i++)
    {
        Console.Write($"{i}, ");
    }
}