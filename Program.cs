
double milhas;
double km;

Console.WriteLine("\t\t\tConversor de Medidas: Milhas para Km");

Console.WriteLine("\nDigite o valor em Milhas:");
milhas = Convert.ToDouble(Console.ReadLine());

km = milhas * 1609;

Console.WriteLine($"Aqui está o valor convertido: {km} Quilômetros");


