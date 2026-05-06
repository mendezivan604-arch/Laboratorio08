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

int[,] errores = new int[filas, columnas];

for (int i = 0; i < filas; i++)
{
    Console.WriteLine($"\nFila {i + 1}");

    for (int j = 0; j < columnas; j++)
    {
        while (true)
        {
            Console.Write($"Ingrese el código en la posición [{i},{j}]: ");

            if (int.TryParse(Console.ReadLine(), out errores[i, j]))
            {
                break;
            }
            else
            {
                Console.WriteLine("Ingrese un código válido.");
            }
        }
    }
}

int codigoBuscar;

while (true)
{
    Console.Write("\nIngrese el código de error a buscar: ");

    if (int.TryParse(Console.ReadLine(), out codigoBuscar))
    {
        break;
    }
    else
    {
        Console.WriteLine("Ingrese un código válido.");
    }
}

bool encontrado = false;

for (int i = 0; i < filas; i++)
{
    for (int j = 0; j < columnas; j++)
    {
        if (errores[i, j] == codigoBuscar)
        {
            Console.WriteLine($"\nEl código {codigoBuscar} fue encontrado en la fila {i} y columna {j}.");
            encontrado = true;
        }
    }
}

if (!encontrado)
{
    Console.WriteLine($"\nEl código {codigoBuscar} no existe en la matriz.");
}
