int filas;
int columnas;

while (true)
{
    Console.Write("Ingrese la cantidad de filas: ");

    if (int.TryParse(Console.ReadLine(), out filas) && filas > 0)
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
    Console.Write("Ingrese la cantidad de columnas: ");

    if (int.TryParse(Console.ReadLine(), out columnas) && columnas > 0)
    {
        break;
    }
    else
    {
        Console.WriteLine("Ingrese un número entero positivo.");
    }
}

int[,] inventario = new int[filas, columnas];

for (int i = 0; i < filas; i++)
{
    Console.WriteLine($"\nFila {i + 1}");

    for (int j = 0; j < columnas; j++)
    {
        while (true)
        {
            Console.Write($"Ingrese el valor para la posición [{i},{j}]: ");

            if (int.TryParse(Console.ReadLine(), out inventario[i, j]))
            {
                break;
            }
            else
            {
                Console.WriteLine("Ingrese un número válido.");
            }
        }
    }
}

int buscar;

while (true)
{
    Console.Write("\nIngrese el número que desea buscar: ");

    if (int.TryParse(Console.ReadLine(), out buscar))
    {
        break;
    }
    else
    {
        Console.WriteLine("Ingrese un número válido.");
    }
}

bool encontrado = false;

for (int i = 0; i < filas; i++)
{
    for (int j = 0; j < columnas; j++)
    {
        if (inventario[i, j] == buscar)
        {
            Console.WriteLine($"\nEl valor {buscar} fue encontrado en la fila {i} y columna {j}.");
            encontrado = true;
        }
    }
}

if (!encontrado)
{
    Console.WriteLine($"\nEl valor {buscar} no existe en la matriz.");
}
