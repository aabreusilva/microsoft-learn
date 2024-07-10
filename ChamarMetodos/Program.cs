//Criando a variando dice onde chama o metodo Random().
//Crio uma variavel roll onde transformo sua funnção em aleatorio e defino os valores de 1 até 7
//Mostra a saída de qualquer valor entre 1 a 7.

Random dice = new Random();
int roll = dice.Next(1, 7);
Console.WriteLine(roll);

//int result = Random.Next();