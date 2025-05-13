internal class Program
{
    private static void Main(string[] args)
    {
        Random random = new Random();
        int current = random.Next(1, 11);

        while (current >= 3)
        {
            Console.WriteLine(current);
            current = random.Next(1, 11);
        }
        Console.WriteLine($"Last number: {current}"); 
    }
}