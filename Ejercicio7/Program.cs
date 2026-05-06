int maquinas;
int turnos;

while (true)
{
    Console.Write("Ingrese la cantidad de máquinas: ");

    if (int.TryParse(Console.ReadLine(), out maquinas) && maquinas > 0)
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
    Console.Write("Ingrese la cantidad de turnos: ");

    if (int.TryParse(Console.ReadLine(), out turnos) && turnos > 0)
    {
        break;
    }
    else
    {
        Console.WriteLine("Ingrese un número entero positivo.");
    }
}

int[,] produccion = new int[maquinas, turnos];

int totalProduccion = 0;

for (int i = 0; i < maquinas; i++)
{
    Console.WriteLine($"\nMáquina {i + 1}");

    for (int j = 0; j < turnos; j++)
    {
        while (true)
        {
            Console.Write($"Ingrese la producción del turno {j + 1}: ");

            if (int.TryParse(Console.ReadLine(), out produccion[i, j]) &&
                produccion[i, j] >= 0)
            {
                totalProduccion += produccion[i, j];
                break;
            }
            else
            {
                Console.WriteLine("Ingrese una cantidad válida.");
            }
        }
    }
}

Console.WriteLine("\n===== RESULTADO =====");
Console.WriteLine($"La producción total de la fábrica es: {totalProduccion}");
