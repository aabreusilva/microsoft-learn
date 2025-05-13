string first = "Hello";
string second = "World";
//O token {0} é substituido pelo primeiro argumento depois do modelo da cadeia de caracteres;
//O token {1} é substituído pelo segundo argumento depois do modelo da cadeia de caracteres;
string result = string.Format("{0} {1}!", first, second);
Console.WriteLine(result);

Console.WriteLine();

//Atualizando o código.
Console.WriteLine("{1} {0}!", first, second);
Console.WriteLine("{0} {0} {0}", first, second);

//Interpolação em cadeia.
Console.WriteLine($"{first} {second}!");
Console.WriteLine($"{second} {first}!");
Console.WriteLine($"{first} {first} {first}!");

//Formatação de moeda.
decimal price = 123.45m;
int discount = 50;
//Adicionando :C aos tokens dentro das chaves formata o número como moeda.
Console.WriteLine($"Price: {price:C} (Save {discount:C})");

Console.WriteLine();

//Formatar números.
decimal measurement = 123456.78912m;
Console.WriteLine($"Measurement: {measurement:N} units");

Console.WriteLine();

//Formatar percentuais.
decimal tax = .3678m;
Console.WriteLine($"Tax rate: {tax:P2}");

Console.WriteLine();

//Combinar abordagens de formatação.
price = 67.55m;
decimal salePrice = 59.99m;
string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price - salePrice), price);
Console.WriteLine(yourDiscount);

Console.WriteLine();

//Combinando várias cadeias de caracteres formatadas.
yourDiscount += $"A discount of {((price - salePrice) / price):P2}"; //inserted.
Console.WriteLine(yourDiscount);

Console.WriteLine("----------------------------------------------------------------------");

//Explorar a interpolação de cadeias de caracteres.
//Exibir o número da fatura usando interpolação de cadeia de caracteres.
int invoiceNumber = 1201;
decimal productShares = 25.4568m;
decimal subtotal = 2750.00m;
decimal taxPercentage = .15825m;
decimal total = 3185.19m;

Console.WriteLine($"Invoice Number: {invoiceNumber}");

//Exibir as ações do produto com precisão de milésimos (0,001)
Console.WriteLine($"   Shares: {productShares:N3} Product.");

//Exibir o subtotal que você cobra do cliente formatando como moeda.
Console.WriteLine($"      Sub total: {subtotal:C}");

//Exibir o imposto cobrado na venda formatado como percentual.
Console.WriteLine($"         Tax: {taxPercentage:P2}");

//Finalizar o recibo com o valor total devido formatado como moeda.
Console.WriteLine($"            Total billed: {total:C}");

//Formatar cadeias de caracteres adicionando um espaço em branco antes ou depois.
string input = "Pad this";
Console.WriteLine(input.PadLeft(12));
Console.WriteLine(input.PadRight(12));

//Adicionando hífen para melhor entendimento.
Console.WriteLine(input.PadLeft(12, '-'));
Console.WriteLine(input.PadRight(12, '-'));

Console.WriteLine();

//Adicionar a ID de pagamento à saída.
string paymentID = "769C";
var formattedLine = paymentID.PadLeft(6);
Console.WriteLine(formattedLine);

Console.WriteLine();

//Adicionar nome favorecido à saída.
string payeeName = "Mr. Alexandre Abreu";

formattedLine = paymentID.PadRight(6);
formattedLine += payeeName.PadRight(12);

Console.WriteLine(formattedLine);

//Adicionando um valor do pagamento na saída.
string paymentAmount = "R$5,000.00";
formattedLine += paymentID.PadRight(6);
formattedLine += paymentAmount.PadRight(24);
Console.WriteLine(formattedLine);