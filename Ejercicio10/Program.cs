int sucursales;
int productos;

while (true)
{
    Console.Write("Ingrese la cantidad de sucursales: ");

    if (int.TryParse(Console.ReadLine(), out sucursales) && sucursales > 0)
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
    Console.Write("Ingrese la cantidad de productos: ");

    if (int.TryParse(Console.ReadLine(), out productos) && productos > 0)
    {
        break;
    }
    else
    {
        Console.WriteLine("Ingrese un número entero positivo.");
    }
}

int[,] inventario = new int[sucursales, productos];

for (int i = 0; i < sucursales; i++)
{
    Console.WriteLine($"\nSucursal {i + 1}");

    for (int j = 0; j < productos; j++)
    {
        while (true)
        {
            Console.Write($"Ingrese la cantidad del producto {j + 1}: ");

            if (int.TryParse(Console.ReadLine(), out inventario[i, j]) &&
                inventario[i, j] >= 0)
            {
                break;
            }
            else
            {
                Console.WriteLine("Ingrese una cantidad válida.");
            }
        }
    }
}

int sucursalBuscada;

while (true)
{
    Console.Write($"\nIngrese el número de la sucursal a consultar (1 - {sucursales}): ");

    if (int.TryParse(Console.ReadLine(), out sucursalBuscada) &&
        sucursalBuscada >= 1 &&
        sucursalBuscada <= sucursales)
    {
        break;
    }
    else
    {
        Console.WriteLine("Ingrese una sucursal válida.");
    }
}

Console.WriteLine($"\n===== INVENTARIO DE LA SUCURSAL {sucursalBuscada} =====");

for (int j = 0; j < productos; j++)
{
    Console.WriteLine($"Producto {j + 1}: {inventario[sucursalBuscada - 1, j]}");
}
