int productos;
int dias;

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

int[,] ventas = new int[productos, dias];

for (int i = 0; i < productos; i++)
{
    Console.WriteLine($"\nProducto {i + 1}");

    for (int j = 0; j < dias; j++)
    {
        while (true)
        {
            Console.Write($"Ingrese las ventas del día {j + 1}: ");

            if (int.TryParse(Console.ReadLine(), out ventas[i, j]) && ventas[i, j] >= 0)
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

int productoBuscado;

while (true)
{
    Console.Write($"\nIngrese el número del producto a consultar (1 - {productos}): ");

    if (int.TryParse(Console.ReadLine(), out productoBuscado) &&
        productoBuscado >= 1 &&
        productoBuscado <= productos)
    {
        break;
    }
    else
    {
        Console.WriteLine("Ingrese un producto válido.");
    }
}


Console.WriteLine($"\nVentas del Producto {productoBuscado}:");

for (int j = 0; j < dias; j++)
{
    Console.WriteLine($"Día {j + 1}: {ventas[productoBuscado - 1, j]}");
}
