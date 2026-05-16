
namespace Ejercicio3
{
    internal class Program
    {
        #region resolución del problema
        static string nombre0;
        static int numeroLibreta0;
        static string nombre1;
        static int numeroLibreta1;
        static string nombre2;
        static int numeroLibreta2;
        static int orden = 0;
        
        static void RegistrarNombreYNumeroLibreta(string nombre, int numeroLibreta)
        {
            if (orden == 0)
            {
                nombre0 = nombre;
                numeroLibreta0 = numeroLibreta;
            }
            else if (orden == 1)
            {
                if (numeroLibreta < numeroLibreta0)
                {
                    nombre1 = nombre0;
                    numeroLibreta1 = numeroLibreta0;
                    nombre0 = nombre;
                    numeroLibreta0 = numeroLibreta;
                }
                else
                {
                    nombre1 = nombre;
                    numeroLibreta1 = numeroLibreta;
                }
            }
            else if (orden == 2)
            {
                if (numeroLibreta < numeroLibreta0)
                {
                    nombre2 = nombre1;
                    numeroLibreta2 = numeroLibreta1;
                    nombre1 = nombre0;
                    numeroLibreta1 = numeroLibreta0;
                    nombre0 = nombre;
                    numeroLibreta0 = numeroLibreta;
                }
                if (numeroLibreta < numeroLibreta1)
                {
                    nombre2 = nombre1;
                    numeroLibreta2 = numeroLibreta1;
                    nombre1 = nombre;
                    numeroLibreta1= numeroLibreta;
                }
                else
                {
                    nombre2 = nombre;
                    numeroLibreta2 = numeroLibreta;
                }
            }
            orden++;
        }

        #endregion

        #region metodos de impresión de pantallas 
        static int MostrarPantallaSolicitarOpcionMenu()
        {
            Console.Clear();
            Console.WriteLine("Ingrese las siguiente opciones:\n\n");
            Console.WriteLine("1- Registrar las notas de los tres alumnos");
            Console.WriteLine("2- Mostrar lista ordenada");
            Console.WriteLine("(otro)- Salir.");
            int op = Convert.ToInt32(Console.ReadLine());
            return op;
        }

        static void MostrarPantallaSolicitarAlumnos()
        {
            Console.Clear();
            Console.WriteLine("Ingrese los nombres de alumnos y el numero de libreta de cada uno \n\n");

            for (int nro = 0; nro < 3; nro++)
            {
                Console.WriteLine("Alumno: " + (nro + 1) + "\n");
                string nombre = Console.ReadLine();
                int nota = Convert.ToInt32(Console.ReadLine());

                RegistrarNombreYNumeroLibreta(nombre, nota);
            }

            Console.WriteLine("\n\n\nPresione una tecla para continuar");
            Console.ReadKey();
        }

        static void MostrarPantallaMostrarListaOrdenada()
        {
            Console.Clear();
            Console.WriteLine("Reparto de dinero: \n\n");

            Console.WriteLine($"{nombre0,20}|{numeroLibreta0,10}");
            Console.WriteLine($"{nombre1,20}|{numeroLibreta1,10}");
            Console.WriteLine($"{nombre2,20}|{numeroLibreta2,10}");

            Console.WriteLine("\n\n\nPresione una tecla para volver al menú principal");
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
                        MostrarPantallaSolicitarAlumnos();
                        break;
                    case 2:
                        MostrarPantallaMostrarListaOrdenada();
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
