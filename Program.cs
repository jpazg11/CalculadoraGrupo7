
Console.WriteLine("Ingrese el primer número: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo número: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Seleccione la operación:");
        Console.WriteLine("1 - Suma");
        Console.WriteLine("2 - Resta");
        Console.WriteLine("3 - Multiplicación");
        Console.WriteLine("4 - División");

        Console.Write("Opción: ");
        int opcion = Convert.ToInt32(Console.ReadLine());

         double resultado = 0;
        bool operacionValida = true;

        switch (opcion)
        {
            case 1:
                resultado = num1 + num2;
                Console.WriteLine($"Resultado: {num1} + {num2} = {resultado}");
                break;
            case 2:
                resultado = num1 - num2;
                Console.WriteLine($"Resultado: {num1} - {num2} = {resultado}");
                break;
            case 3:
                resultado = num1 * num2;
                Console.WriteLine($"Resultado: {num1} * {num2} = {resultado}");
                break;
            case 4:
                if (num2 != 0)
                {
                    resultado = (double)num1 / num2;
                    Console.WriteLine($"Resultado: {num1} / {num2} = {resultado}");
                }
                else
                {
                    Console.WriteLine("Error: No se puede dividir entre cero.");
                    operacionValida = false;
                }
                break;
            default:
                Console.WriteLine("Opción inválida.");
                operacionValida = false;
                break;
        }

if (operacionValida)
{
    Console.WriteLine("¡Operación completada con éxito!");
}

