//Descobrir Split()e Join()
//Usar ToCharArray() para reverter um string.

string value = "abc123";
char[] valueArray = value.ToCharArray();
Array.Reverse(valueArray);
string result = new string(valueArray);
Console.WriteLine(result);

//Combine todos  os caracteres em uma nova cadeia de caracteres com valor separado por vírgulausando Join().
string values = "ABC123";
char[] valueArray1 = values.ToCharArray();
Array.Reverse(valueArray1);
//string results = new string(valueArray1);
string result1 = string.Join(",", valueArray1);
Console.WriteLine(result1);

//Split()a nova cadeia de caracteres de valor separado por vírgula em uma matriz de cadeias de caracteres.
string[] items = result1.Split(',');
foreach (string item in items)
{
    Console.WriteLine(item);
}

//Escrever um codigo para inverter cada palavra de uma mensagem.
string pangram = "The quick brown fox jumps over the lazy dog";
//char[] pangramArray = pangram.ToCharArray();
//Array.Reverse(pangramArray);
//string pangramResult = new string(pangramArray);
//Console.WriteLine(pangramResult);

//Correção:
string[] message = pangram.Split(' ');
string[] newMessage = new string[message.Length];

for (int i = 0; i < message.Length; i++)
{
    char[]letters = message[i].ToCharArray();
    Array.Reverse(letters);
    newMessage[i] = new string(letters);
}
string result2 = string.Join(" ", newMessage);
Console.WriteLine(result2);