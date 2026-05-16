namespace Ejercicio1
{
    internal class Program
    {
        #region resolución del problema
        static int acumulado;
        static int contador;
        static int maximo;
        static int minimo;

        static void RegistrarValor(int valor)
        { 
            acumulado = valor;
            contador++;

            if (contador == 1 || valor > maximo)
            {
                maximo= valor;
            }
            if (contador == 1 || valor > minimo)
            {
                minimo = valor;
            }
        }

        static double CalcularPromedio()
        {
            double promedio = 0;
            if(contador>0)
                promedio = 1.0*acumulado / contador;
            return promedio;
        }

        #endregion

        #region metodos de impresión de pantallas
        static int MostrarPantallaSolicitarOpcionMenu()
        {
            Console.Clear();
            Console.WriteLine("Ingrese las siguiente opciones:");
            Console.WriteLine("1- Procesar un solo número");
            Console.WriteLine("2- Procesar varios números.");
            Console.WriteLine("3- Mostrar máximo y mínimo.");
            Console.WriteLine("4- Mostrar promedio.");
            Console.WriteLine("5- Mostrar cantidad de números ingresados.");
            Console.WriteLine("6- Reiniciar variables.");
            Console.WriteLine("(otro)- Salir.");
            int op = Convert.ToInt32(Console.ReadLine());
            return op;
        }
        static void MostrarPantallaIniciarVariables()
        {
            Console.Clear();
            Console.WriteLine("Reiniciando las variables\n\n");
            acumulado = 0;
            contador = 0;
            Console.WriteLine("Presione una tecla para continuar");
            Console.ReadKey();
        }
        static void MostrarPantallaSolicitarNumero()
        {
            Console.Clear();
            Console.WriteLine("Ingrese un número:\n\n");
            int valor = Convert.ToInt32(Console.ReadLine());
            RegistrarValor(valor);
        }
        static void MostrarPantallaSolicitarVariosNumeros()
        {
            Console.Clear();
            Console.WriteLine("Ingrese  cuantos números va a ingresar\n\n");
            int cantidad = Convert.ToInt32(Console.ReadLine());

            for (int n = 0; n < cantidad; n++)
            {
                MostrarPantallaSolicitarNumero();
            }
        }
        static void MostrarPantallaMaximoMinimo()
        {
            Console.Clear();
            Console.WriteLine("Máximo y Mínimo");

            Console.WriteLine("Máximo: " + maximo);
            Console.WriteLine("Mímimo: " + minimo+"\n\n\n");
            Console.WriteLine("Presione una tecla para volver al menú principal");
            Console.ReadKey();
        }
        static void MostrarPantallaCalcularYMostrarPromedio()
        {
            Console.Clear();

            Console.WriteLine("Pantalla de promedio\n\n");

            if (contador > 0)
            {
                Console.WriteLine("Promedio: " +CalcularPromedio());
            }
            else
            {
                Console.WriteLine("Promedio: No se han ingresado números");
            }

            Console.WriteLine("Presione una tecla para volver al menú principal");
            Console.ReadKey();
        }
        static void MostrarPantallaCantidad()
        {
            Console.Clear();

            Console.WriteLine("Pantalla de cantidad de valores procesados\n\n");

            if (contador > 0)
            {
                Console.WriteLine("Cantidad: " + contador);
            }
            else
            {
                Console.WriteLine("Cantidad: No se han ingresado números");
            }

            Console.WriteLine("Presione una tecla para volver al menú principal");
            Console.ReadKey();
        }
        #endregion

        static void Main(string[] args)
        {
            MostrarPantallaIniciarVariables();

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
                        MostrarPantallaSolicitarNumero();
                        break;
                    case 2:
                        MostrarPantallaSolicitarVariosNumeros();
                        break;
                    case 3:
                        MostrarPantallaMaximoMinimo();
                        break;
                    case 4:
                        MostrarPantallaCalcularYMostrarPromedio();
                        break;
                    case 5:
                        MostrarPantallaCantidad();
                        break;
                    case 6:
                        MostrarPantallaIniciarVariables();
                        break;
                    default:
                        op = -1;
                        break;
                }
                #endregion

            } while (op != -1);
            #endregion

            Console.WriteLine("Presione cualquier tecla para terminar el programa.");
            Console.ReadKey();
        }
    }
}
