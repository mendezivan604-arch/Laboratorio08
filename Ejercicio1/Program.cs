int zonas;
int dias;

while (true)
{
    Console.Write("Ingrese la cantidad de zonas: ");
    if(int.TryParse(Console.ReadLine(), out zonas) && zonas > 0)
    {
        break;
    }
    else
    {
        Console.WriteLine("Por favor, ingrese un número entero positivo para las zonas.");
    }
}
while(true)
{
    Console.Write("Ingrese la cantidad de días: ");
    if(int.TryParse(Console.ReadLine(), out dias) && dias > 0)
    {
        break;
    }
    else
    {
        Console.WriteLine("Por favor, ingrese un número entero positivo para los días.");
    }
}

double[,] temperaturas = new double[zonas, dias];

for (int i = 0; i < zonas; i++)
{
    Console.WriteLine($"Zona {i + 1}");

    for (int j = 0; j < dias; j++)
    {
        Console.Write($"Ingrese la temperatura del día {j + 1}: ");
        temperaturas[i, j] = double.Parse(Console.ReadLine());
    }
}

Console.WriteLine("===== TABLA DE TEMPERATURAS =====");

Console.Write("Zona/Día\t");
for (int j = 0; j < dias; j++)
{
    Console.Write($"Día {j + 1}\t");
}
Console.WriteLine();

for (int i = 0; i < zonas; i++)
{
    Console.Write($"Zona {i + 1}\t\t");

    for (int j = 0; j < dias; j++)
    {
        Console.Write($"{temperaturas[i, j]}\t");
    }

    Console.WriteLine();
}
