int apartamentos;
int dias;

while (true)
{
    Console.Write("Ingrese la cantidad de apartamentos: ");

    if (int.TryParse(Console.ReadLine(), out apartamentos) && apartamentos > 0)
    {
        break;
    }
    else
    {
        Console.WriteLine("Ingrese un número entero positivo.");
    }
}

while (true)
{
    Console.Write("Ingrese la cantidad de días: ");

    if (int.TryParse(Console.ReadLine(), out dias) && dias > 0)
    {
        break;
    }
    else
    {
        Console.WriteLine("Ingrese un número entero positivo.");
    }
}

double[,] consumos = new double[apartamentos, dias];

for (int i = 0; i < apartamentos; i++)
{
    Console.WriteLine($"\nApartamento {i + 1}");

    for (int j = 0; j < dias; j++)
    {
        while (true)
        {
            Console.Write($"Ingrese el consumo del día {j + 1}: ");

            if (double.TryParse(Console.ReadLine(), out consumos[i, j]) && consumos[i, j] >= 0)
            {
                break;
            }
            else
            {
                Console.WriteLine("Ingrese un consumo válido.");
            }
        }
    }
}

double totalConsumo = 0;

for (int i = 0; i < apartamentos; i++)
{
    for (int j = 0; j < dias; j++)
    {
        totalConsumo += consumos[i, j];
    }
}

Console.WriteLine("\n===== RESULTADO =====");
Console.WriteLine($"El consumo total acumulado es: {totalConsumo}");
    
