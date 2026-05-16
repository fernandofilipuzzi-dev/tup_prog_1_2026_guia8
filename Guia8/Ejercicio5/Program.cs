
namespace Ejercicio5
{
    internal class Program
    {
        #region resolución del problema
        
        static int DeterminarLosDíasDelMes(int mes, int año)
        {
            //este algoritmose puede mejorar - pero hay que cambiar la estrategia.

            int dias;

            #region determinar si espar
            bool esPar = mes % 2 == 0;
            #endregion 

            #region determinar si el mes esta en la primera mitad del año
            bool esPrimeraMitad = mes <= 6;
            #endregion

            #region verifico primera mitad
            if (esPrimeraMitad)
            {
                #region verifico si el mes es par
                if (esPar)
                {
                    if (mes == 2)
                    {
                        #region verifico si el año es bisiesto
                        if (DeterminarSiEsBisiesto(año))
                        {
                            dias=29;
                        }
                        else
                        {
                            dias=28;
                        }
                        #endregion
                    }
                    else
                    {
                        return 30;
                    }
                }
                else
                {
                    return 30;
                }
                #endregion
            }
            else
            {
                #region verifico si el mes impar
                if (esPar)
                {
                    dias=31;
                }
                else
                {
                    dias=30;
                }
                #endregion
            }
            #endregion

            return dias;
        }
        static bool DeterminarSiEsBisiesto(int año)
        {
            bool esBisiesto = false;

            #region verificar si es multiplo de 4
            if (año % 4 == 0)
            {
                #region verificar que no sea multiplo de 100 o verifico que sea multiplo de 400
                if (año % 100 != 0 || año % 400 == 0)
                {
                    esBisiesto = true;
                }
                else
                {
                    esBisiesto = false;
                }
                #endregion
            }
            else
            { 
                esBisiesto = false;
            }
            #endregion 
            return esBisiesto;
        }
        #endregion

        #region metodos de impresion de pantallas
        static int MostrarPantallaSolicitarOpcionMenu()
        {
            Console.Clear();
            Console.WriteLine("Ingrese las siguiente opciones:\n\n");
            Console.WriteLine("1- Determinar Días del mes.");
            Console.WriteLine("2- Verificar Si el año es bisiesto");
            Console.WriteLine("(otro)- Salir.");
            int op = Convert.ToInt32(Console.ReadLine());
            return op;
        }
        static void MostrarPantallaSolicitarMesAñoYDeterminarDias()
        {
            Console.Clear();
            Console.WriteLine("Determinar cantidad de días del mes \n\n");

            Console.WriteLine("Ingrese el mes (1 al 12):\n");
            int mes = Convert.ToInt32( Console.ReadLine() );

            Console.WriteLine("\nIngrese el año:\n");
            int año = Convert.ToInt32(Console.ReadLine());

            int cantidadDias = DeterminarLosDíasDelMes(mes, año);

            Console.WriteLine($"\n\nLa cantidad de días del més ({mes}) es: \n\t\t\t{cantidadDias}\n\n\n");

            Console.WriteLine("\n\n\nPresione una tecla para continuar");
            Console.ReadKey();
        }
        static void MostrarPantallaVerificarSiElAñoEsBisiesto()
        {
            Console.Clear();
            Console.WriteLine("Determinar si el año es bisiesto. \n\n");

            Console.WriteLine("\nIngrese el año:\n");
            int año = Convert.ToInt32(Console.ReadLine());

            if(DeterminarSiEsBisiesto(año))
            {
                Console.WriteLine("El año es bisiesto");
            }
            else
            {
                Console.WriteLine("El año no es bisiesto");
            }
            
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
                        MostrarPantallaSolicitarMesAñoYDeterminarDias();
                        break;
                    case 2:
                        MostrarPantallaVerificarSiElAñoEsBisiesto();
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
