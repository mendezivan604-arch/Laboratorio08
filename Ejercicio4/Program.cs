int estudiantes;
int evaluaciones;

while (true)
{
    Console.Write("Ingrese la cantidad de estudiantes: ");

    if (int.TryParse(Console.ReadLine(), out estudiantes) && estudiantes > 0)
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
    Console.Write("Ingrese la cantidad de evaluaciones: ");

    if (int.TryParse(Console.ReadLine(), out evaluaciones) && evaluaciones > 0)
    {
        break;
    }
    else
    {
        Console.WriteLine("Ingrese un número entero positivo.");
    }
}

double[,] notas = new double[estudiantes, evaluaciones];

double notaMayor = 0;

for (int i = 0; i < estudiantes; i++)
{
    Console.WriteLine($"\nEstudiante {i + 1}");

    for (int j = 0; j < evaluaciones; j++)
    {
        while (true)
        {
            Console.Write($"Ingrese la nota de la evaluación {j + 1}: ");

            if (double.TryParse(Console.ReadLine(), out notas[i, j]) &&
                notas[i, j] >= 0)
            {
                if (notas[i, j] > notaMayor)
                {
                    notaMayor = notas[i, j];
                }

                break;
            }
            else
            {
                Console.WriteLine("Ingrese una nota válida.");
            }
        }
    }
}

Console.WriteLine("\n===== RESULTADO =====");
Console.WriteLine($"La nota más alta del grupo es: {notaMayor}");
