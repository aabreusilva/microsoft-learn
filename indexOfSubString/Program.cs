//IndexOf() serve para localizar posição de um ou mais caracteres ou uma cadeia de catacteres dentro de uma cadeia maiot
string message = "Find that is (inside the parentheses)";
int openingPosition = message.IndexOf('(');
int closingPosition = message.IndexOf(')');
Console.WriteLine(openingPosition);
Console.WriteLine(closingPosition);

Console.WriteLine("");

//Modificar a posição inicial da subcadeia de caracteres.
//13 = 13 + 1 => 14
openingPosition += 1;

//36 - 14 = 22
int length = closingPosition - openingPosition;

//14~26
Console.WriteLine(message.Substring(openingPosition, length));

Console.WriteLine("");

//Atualizando o código.
string message1 = "What is the value <span>between the targs</span>?";
int openingPosition1 = message1.IndexOf("<span>");
int closingPosition1 = message1.IndexOf("</span>");

openingPosition1 += 6;
int length1 = closingPosition1 - openingPosition1;
Console.WriteLine(message1.Substring(openingPosition1, length1));