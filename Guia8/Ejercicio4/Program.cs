
namespace Ejercicio4
{
    internal class Program
    {
        #region resolución del problema
        static string jugador1;
        static int setGanados1;
        static string jugador2;
        static int setGanados2;
        
        static void RegistrarJugadores(string nombre1, string nombre2)
        {
            jugador1 = nombre1;
            jugador2 = nombre2;
            setGanados1 = 0;
            setGanados2 = 0;
        }
        static void RegistrarResultadoSet(int resultado1, int resultado2)
        {
            setGanados1 += resultado1;
            setGanados2 += resultado2;
        }
        static string DeterminarGanador()
        {
            if (setGanados1 > setGanados2)
                return jugador1;
            else if (setGanados1 < setGanados2)
                return jugador2;
            return "No hay ganador";
        }
        #endregion

        #region metodos de impresión de pantallas
        static int MostrarPantallaSolicitarOpcionMenu()
        {
            Console.Clear();
            Console.WriteLine("Ingrese las siguiente opciones:\n\n");
            Console.WriteLine("1- Registrar los nombres de los dos jugadores.");
            Console.WriteLine("2- Registrar los resultados de cada set de los jugadores.");
            Console.WriteLine("3- Mostrar el ganador.");
            Console.WriteLine("(otro)- Salir.");
            int op = Convert.ToInt32(Console.ReadLine());
            return op;
        }
        static void MostrarPantallaSolicitarNombreJugadores()
        {
            Console.Clear();
            Console.WriteLine("Ingrese los nombres de los dos jugadores \n\n");

            string nombre1 = Console.ReadLine();
            string nombre2 = Console.ReadLine();

            RegistrarJugadores(nombre1, nombre2);

            Console.WriteLine("\n\n\nPresione una tecla para continuar");
            Console.ReadKey();
        }
        static void MostrarPantallaSolicitarResultadoSet()
        {
            Console.Clear();
            Console.WriteLine("Ingrese los resultados del set de cada jugador \n\n");

            int resultado1 = Convert.ToInt32(Console.ReadLine());
            int resultado2 = Convert.ToInt32(Console.ReadLine());

            RegistrarResultadoSet(resultado1, resultado2);

            Console.WriteLine("\n\n\nPresione una tecla para continuar");
            Console.ReadKey();
        }
        static void MostrarPantallaGanador()
        {
            Console.Clear();
            Console.WriteLine("Ganador: \n\n");

            string ganador = DeterminarGanador();
            Console.WriteLine($"{ganador} \n\n");

            Console.WriteLine("\n\n\nPresione una tecla para continuar");
            Console.ReadKey();
        }

        #endregion

        static void Main(string[] args)
        {
            int op;

            #region iterar opciones menú
            do
            {
                #region solicitar opción
                op = MostrarPantallaSolicitarOpcionMenu();
                #endregion

                #region verificar opción
                switch (op)
                {
                    case 1:
                        MostrarPantallaSolicitarNombreJugadores();
                        break;
                    case 2:
                        MostrarPantallaSolicitarResultadoSet();
                        break;
                    case 3:
                        MostrarPantallaGanador();
                        break;
                    default:
                        op = -1;
                        break;
                }
                #endregion
            }
            while (op != -1);
            #endregion

            Console.WriteLine("Presione cualquier tecla para terminar el programa.");
            Console.ReadKey();
        }
    }
}
