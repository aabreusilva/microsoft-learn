using Humanizer;

Console.WriteLine("Quantities: ");
HumanizeQuantities();
Console.WriteLine("\nDate/Time Manipulation: ");
HumanizeDates();

static void HumanizeQuantities()
{
    Console.WriteLine("case".ToQuantity(0));
    Console.WriteLine("case".ToQuantity(1));
    Console.WriteLine("case".ToQuantity(5));
}

static void HumanizeDates()
{
    Console.WriteLine(DateTime.UtcNow.AddHours(-24).Humanize()); //-24 horas atrás (ontem).
    Console.WriteLine(DateTime.UtcNow.AddHours(-2).Humanize()); //aconteceu a 2 horas atrás.
    Console.WriteLine(TimeSpan.FromDays(1).Humanize()); //1 dia.
    Console.WriteLine(TimeSpan.FromDays(16).Humanize());//2 semanas arredondado.
}