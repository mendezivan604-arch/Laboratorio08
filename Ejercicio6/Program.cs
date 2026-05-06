int estudiantes;
int dias;

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

int[,] asistencia = new int[estudiantes, dias];

for (int i = 0; i < estudiantes; i++)
{
    Console.WriteLine($"\nEstudiante {i + 1}");

    for (int j = 0; j < dias; j++)
    {
        while (true)
        {
            Console.Write($"Ingrese asistencia del día {j + 1} (1 = Asistió, 0 = No asistió): ");

            if (int.TryParse(Console.ReadLine(), out asistencia[i, j]) &&
                (asistencia[i, j] == 0 || asistencia[i, j] == 1))
            {
                break;
            }
            else
            {
                Console.WriteLine("Ingrese únicamente 1 o 0.");
            }
        }
    }
}

int estudianteBuscado;

while (true)
{
    Console.Write($"\nIngrese el número del estudiante a consultar (1 - {estudiantes}): ");

    if (int.TryParse(Console.ReadLine(), out estudianteBuscado) &&
        estudianteBuscado >= 1 &&
        estudianteBuscado <= estudiantes)
    {
        break;
    }
    else
    {
        Console.WriteLine("Ingrese un estudiante válido.");
    }
}

Console.WriteLine($"\n===== REGISTRO DE ASISTENCIA DEL ESTUDIANTE {estudianteBuscado} =====");

for (int j = 0; j < dias; j++)
{
    if (asistencia[estudianteBuscado - 1, j] == 1)
    {
        Console.WriteLine($"Día {j + 1}: Asistió");
    }
    else
    {
        Console.WriteLine($"Día {j + 1}: No asistió");
    }
}
