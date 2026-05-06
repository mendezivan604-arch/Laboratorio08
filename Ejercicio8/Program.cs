int jugadores;
int niveles;

while (true)
{
    Console.Write("Ingrese la cantidad de jugadores: ");

    if (int.TryParse(Console.ReadLine(), out jugadores) && jugadores > 0)
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
    Console.Write("Ingrese la cantidad de niveles: ");

    if (int.TryParse(Console.ReadLine(), out niveles) && niveles > 0)
    {
        break;
    }
    else
    {
        Console.WriteLine("Ingrese un número entero positivo.");
    }
}

int[,] puntajes = new int[jugadores, niveles];

int puntajeMayor = 0;

for (int i = 0; i < jugadores; i++)
{
    Console.WriteLine($"\nJugador {i + 1}");

    for (int j = 0; j < niveles; j++)
    {
        while (true)
        {
            Console.Write($"Ingrese el puntaje del nivel {j + 1}: ");

            if (int.TryParse(Console.ReadLine(), out puntajes[i, j]) &&
                puntajes[i, j] >= 0)
            {
                if (puntajes[i, j] > puntajeMayor)
                {
                    puntajeMayor = puntajes[i, j];
                }

                break;
            }
            else
            {
                Console.WriteLine("Ingrese un puntaje válido.");
            }
        }
    }
}

Console.WriteLine("\n===== RESULTADO =====");
Console.WriteLine($"El puntaje más alto obtenido es: {puntajeMayor}");
