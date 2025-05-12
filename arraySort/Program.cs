string[] pallets = ["B14", "A11", "B12", "A13"];
Console.WriteLine("Sorted...");
Array.Sort(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"--{pallet}");
}

//Inverter a ordem dos pallets.
Console.WriteLine("");
Console.WriteLine("Reversed...");
Array.Reverse(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"--{pallet}");
}

//Limpar e redimensionar uma matriz.
string[] pallets1 = ["B14", "A11", "B12", "A13"];
Console.WriteLine("");
Console.WriteLine("Clearing...");
Array.Clear(pallets1, 0, 2);
Console.WriteLine($"Clearing 2... count: {pallets1.Length}");
foreach (var pallet1 in pallets1)
{
    Console.WriteLine($"-- {pallets1}");
}
