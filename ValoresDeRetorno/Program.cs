/*Ao chamar um método que retorna um valor, geralmente você atribui o valor de retorno a uma variável.
 * Dessa forma, é possível usar o valor posteriormente no código. No cenário do lançamento de dados,
 * você atribuiu o valor de retorno de Random.Next() à variável roll:
 */
Random dice = new Random();
int roll = dice.Next(1, 7);

/*Em alguns casos, é possível usar o valor de retorno diretamente sem atribuílos á uma variável. Por exemplo,
 * é possível imprimir o valor de retorno no console da seguinte maneira:
 */
Console.WriteLine(dice.Next(1, 7));

/*Mesmo que um método retorne um valor, é possível chama-lo sem usar o valor de retorno. Por exemplo, 
 * é possível ignorar o valor de retorno chamando o método da seguinte maneira: 
 */
dice.Next(1, 7);
//Porém seria inútil, pois o motivo de chamar o método Next() é para recuperar o próximo valor aleatório.

/*Quando um chamador invoca o método, ele fornece valores concretos, chamados argumentos(1, 7), para cada parâmetro. Os
 * argumentos devem ser compatíveis com o parâmetro de tipo. Entretanto, o nome do argumento, se for usado no código
 * de chamada, não precisará ser o mesmo que o nome do parâmetroo definido no método.*/
Random dice1 = new Random();
int roll1 = dice1.Next();
Console.WriteLine(roll1);

//Exercício: Chamar o método Random.Next() para gerar valores inteiros aleatórios com diferentes níveis de restrição.
Random dados = new Random();
int roletar = dados.Next();
int roletar1 = dados.Next(101);
int roletar2 = dados.Next(50, 101);

Console.WriteLine($"First roll: {roletar}"); //Não define um valor máximo.
Console.WriteLine($"Second roll: {roletar1}"); //Valor mínimo 0, máx 101.
Console.WriteLine($"Third roll: {roletar2}"); //Valor mínimo 50, máx 101.