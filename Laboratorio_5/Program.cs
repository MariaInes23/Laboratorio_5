
using Microsoft.VisualBasic;

int opcion = 0;
do
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("╔═════════════════════════════════════╗");
    Console.WriteLine("║    BIENVENIDOS A GESTOR DE TAREAS   ║");
    Console.WriteLine("╚═════════════════════════════════════╝");
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("╔═════════════════════════════════════╗");
    Console.WriteLine("║1. Añadir Tarea                      ║");
    Console.WriteLine("║2. Ver todas las Tareas              ║");
    Console.WriteLine("║3. Marcar tareas como completadas    ║");
    Console.WriteLine("║4. Salir                             ║");
    Console.WriteLine("╚═════════════════════════════════════╝");
    Console.WriteLine(); Console.ForegroundColor = ConsoleColor.DarkBlue; 
    Console.Write("Ingresa la opcion: ");
    try
    {
        opcion = Convert.ToInt32(Console.ReadLine()); Console.ResetColor();
        switch (opcion)
        {
            case 1: 
                Console.WriteLine("╔═══════════════════════╗");
                Console.WriteLine("║      AÑADIR TAREA     ║");
                Console.WriteLine("╚═══════════════════════╝");
                break;
            case 2:
                Console.WriteLine("╔═══════════════════════╗");
                Console.WriteLine("║       VER TAREA       ║");
                Console.WriteLine("╚═══════════════════════╝");
                break;
            case 3:
                Console.WriteLine("╔════════════════════════════════════╗");
                Console.WriteLine("║       MARCAR COMO COMPLETADA       ║");
                Console.WriteLine("╚════════════════════════════════════╝");
                break;
            case 4:
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Saliendo...");
                Console.WriteLine("╔════════════════════════════════════════════╗");
                Console.WriteLine("║        GRACIAS POR USAR EL PROGRAMA        ║");
                Console.WriteLine("╚════════════════════════════════════════════╝");
                Console.ResetColor();
                break;
            default:
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Esta opción no existe. Intenta de nuevo");
                Console.ResetColor();
                MensajeContinuar();
                break;
        }
    }
    catch (FormatException)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Error de formato. Intenta de nuevo");
        MensajeContinuar();
    }
} while (opcion != 4);

void MensajeContinuar()
{
    Console.ForegroundColor = ConsoleColor.DarkGray;
    Console.Write("Presiona ENTER para continuar");
    Console.ReadKey(); Console.Clear(); Console.ResetColor();
}