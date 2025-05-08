internal class Program
{
    public static void Main(string[] args)
    {
        //Utilizar o método TryParse() para analisar uma cadeira de caracteres como um int.
        string value = "102";
        int result = 0;
        if (int.TryParse(value, out result))
        {
            Console.WriteLine($"Measurement: {result}");
        }
        else
        {
            Console.WriteLine("Unable to report the measurement.");
        }
        //Analisando o int.
        Console.WriteLine($"Measurement (w/ offset): {50 + result}");

        //Modificando a variável de cadeia de caracteres para um valor que não possa ser analisadoo.
        string value1 = "bad";
        if (result > 0)
        {
            Console.WriteLine($"Measurement (w/ offset: {50 + result}");
        }
    }
}