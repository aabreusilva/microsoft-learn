string[] ipv4 = { "107.31.1.5", "255.0.0.255", "555..0.555", "255...255" };
string[] address;

/*Criando variáveis para armazenar os valores de validação.*/
bool validLength = false;
bool validZeroes = false;
bool validRange = false;

foreach (string ip in ipv4)
{
    /* Impedindo que o código falhe ao tentar converter uma string vazia em um número inteiro, utilizando StringSplitOptions.RemoveEmptyEntries.*/
    address = ip.Split(".", StringSplitOptions.RemoveEmptyEntries);

    ValidateLength();
    ValidateRange();
    ValidateZeroes();

    /* Corrigindo os dados de entrada que cada método usa desde que atualizei o ipv4 de uma cadeia de
     * caracteres para um vetor. Como cada métodousa string.Split, pode-se declarar uma variável para
     * armazenar o resultado de string.Split e usar em cada método.
     */

    if (validLength && validZeroes && validRange)
    {
        Console.WriteLine($"{ip} is a valid IPv4 address.");
    }
    else
    {
        Console.WriteLine($"{ip} is an invalid IPv4 address.");
    }
}

void ValidateLength()
{
    /* A primeira regra afirma que o endereço ipv4 precisa ter 4 números. */
    validLength = address.Length == 4; 
}

void ValidateZeroes()
{
    foreach (string number in address)
    {

        /*A segunda regra afirma que o endereço ipv4 não pode ter mais de um zero a esquerda. 
         * Por isso o método verifica os números de zero à esquerda ao aceitar 0 como número 
         * válido. Caso todos os números tenham zeros válidos,validZeroes deverá ser true e 
         * false, caso contrário. Portanto, você verifica cada número com mais de um dígito 
         * não comela com um zero.*/

        if (number.Length > 1 && number.StartsWith("0"))
        {
            validZeroes = false;
            return;
            
            /*Correção do bug: o código não estava retornando após encontrar um zero à esquerda inválido. 
             * A instrução return encerra o método e retorna o controle ao chamador do método. Adicionando 
             * o mesmo depois que o primeiro 0 inválido for encontrado. Se nenhum 0 for encontrado, 
             * o método será encerrado após a configuração de validZeroes como true.*/
        }
    }
    
    /*Caso nenhum zero à esquerda for econtrado, validZeroes será true.*/
    validZeroes = true;

}
/*A terceira regra afrima que cada número no endereço ipv4 deve variar de 0 a 255. Portanto, você verifica se cada número é menor que 255 e, 
 * caso contrário, encerre a execução após definir validRange como false. Como a cadeia de caracteres de entrada contém apenas dígitos e pontos,
 * você não precisa verificar se há números negativos. Só que, pode haver um caso em que nenhum dígito esteja presente entre os pontos. Por exemplo,
 * "255...255". Nesse caso, string.Split(".") retornaria entradas vazias, causando falha em int.Parse. Você pode impedir isso especificando o
 * StringSplitOptions.RemoveEmptyEntries como segundo argumento para o método Split.
 */

void ValidateRange() 
{ 
    foreach (string number in address)
    {
        int value = int.Parse(number);
        
        if (value < 0 || value > 255)
        {
            validRange = false;
            return;
        }
    }
    validRange = true;
}