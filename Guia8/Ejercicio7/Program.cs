
namespace Ejercicio7;

internal class Program
{
    #region resolución del problema
    static int cantidad1;
    static int cantidad2;
    static int cantidad3;
    static int cantidad4;
    static int cantidad5;
    static int numeroTransaccionMayor;
    static double montoTransaccionMayor;

    static int contadorDeTransacciones = 0;

    static double porcentajeCantidadRubro1;
    static double porcentajeCantidadRubro2;
    static double porcentajeCantidadRubro3;
    static double porcentajeCantidadRubro4;
    static double porcentajeCantidadRubro5;

    static double recaudacionTotal=0;

    static void InicializarVariables()
    {
        cantidad1=0;
        cantidad2=0;
        cantidad3 = 0;
        cantidad4 = 0;
        cantidad5 = 0;
        numeroTransaccionMayor = 0;
        montoTransaccionMayor = 0;

        contadorDeTransacciones = 0;

        porcentajeCantidadRubro1=0;
        porcentajeCantidadRubro2 = 0;
        porcentajeCantidadRubro3 = 0;
        porcentajeCantidadRubro4 = 0;
        porcentajeCantidadRubro5 = 0;

        recaudacionTotal = 0;
    }

    static void EvaluarTransaccionPuntoDeVenta(int nroTransaccion, int rubro, int cantidad, double monto)
    {
        switch (rubro)
        {
            case 1:
                cantidad1 +=cantidad ;
                break;
            case 2:
                cantidad2 += cantidad;
                break;
            case 3:
                cantidad3 += cantidad;
                break;
            case 4:
                cantidad4 += cantidad;
                break;
            case 5:
                cantidad5 += cantidad;
                break;
            default:
                break;
        }
        recaudacionTotal += monto;

        if (contadorDeTransacciones == 0 || monto > montoTransaccionMayor)
        {
            numeroTransaccionMayor = nroTransaccion;
            montoTransaccionMayor = monto;
        }
    }
    static void CalcularPorcentajesCantidadVentasPorRubro()
    {
        int CantidadTotal = cantidad1 + cantidad2 + cantidad3 + cantidad4 + cantidad5;

        porcentajeCantidadRubro1 = 0;
        porcentajeCantidadRubro2 = 0;
        porcentajeCantidadRubro3 = 0;
        porcentajeCantidadRubro4 = 0;
        porcentajeCantidadRubro5 = 0;

        if (CantidadTotal > 0)
        {
            porcentajeCantidadRubro1 = 100.0 * cantidad1 / CantidadTotal;
            porcentajeCantidadRubro2 = 100.0 * cantidad2 / CantidadTotal;
            porcentajeCantidadRubro3 = 100.0 * cantidad3 / CantidadTotal;
            porcentajeCantidadRubro4 = 100.0 * cantidad4 / CantidadTotal;
            porcentajeCantidadRubro5 = 100.0 * cantidad5 / CantidadTotal;
        }
    }
    #endregion

    #region metodos de impresión de pantallas
    static int MostrarPantallaSolicitarOpcionMenu()
    {
        Console.Clear();
        Console.WriteLine(@"Ingrese las siguiente opciones:

1- Ingresar un resumen de venta
2- Mostrar Número de transacción registrado con el mayor monto total.
3- Mostrar porcentaje de cantidad por rubro.
4- Mostrar la recaudación total.
(otro)- Salir.
");

        int op = Convert.ToInt32( Console.ReadLine() );
        return op;
    }

    static void MostrarPantallaRegistrarTransaccion()
    {
        Console.Clear();
        Console.WriteLine("Registre la transacción de venta. \n\n");

        Console.WriteLine("\nNumero de transacción: \n");
        int nro=Convert.ToInt32( Console.ReadLine() );

        Console.WriteLine("\n\n\nNumero de rubro (de 1 a 5): \n");
        int rubro = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\n\n\nCantidad de productos: \n");
        int cantidad = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\n\n\nMonto total de la transacción: \n");
        double monto = Convert.ToDouble(Console.ReadLine());

        EvaluarTransaccionPuntoDeVenta(nro, rubro, cantidad, monto);

        Console.WriteLine("\n\n\n\n\nPresione una tecla para continuar");
        Console.ReadKey();
    }

    static void MostrarPantallaTransaccionMayorMonto()
    {
        Console.Clear();
        Console.WriteLine($@"Transacción con mayor monto en ventas


Número de transacción: {numeroTransaccionMayor}
Monto Total: ${montoTransaccionMayor:f2}


Presione una tecla para continuar");
        Console.ReadKey();
    }

    static void MostrarPantallaPorcentajeDeCantidadesPorRubro()
    {
        Console.Clear();
        CalcularPorcentajesCantidadVentasPorRubro();

        Console.WriteLine($@"
Porcentaje de ventas por rubo 
                       

Rubro 1: {porcentajeCantidadRubro1:f2}%
Rubro 2: {porcentajeCantidadRubro2:f2}%
Rubro 3: {porcentajeCantidadRubro3:f2}%
Rubro 4: {porcentajeCantidadRubro4:f2}%
Rubro 5: {porcentajeCantidadRubro5:f2}%



Presione una tecla para continuar");
        Console.ReadKey();
    }
    
    static void MostrarPantallaMontoRecaudadoTotal()
    {
        Console.Clear();
        Console.WriteLine($@"Monto total recaudado.


Monto: ${recaudacionTotal:f2}


Presione una tecla para continuar");
        Console.ReadKey();
    }

    #endregion

    static void Main(string[] args)
    {
        InicializarVariables();

        int op = MostrarPantallaSolicitarOpcionMenu();

        #region iterar opciones menú
        while (op != -1)
        {
            #region verificar opción
            switch (op)
            {
                case 1:
                    MostrarPantallaRegistrarTransaccion();
                    break;
                case 2:
                    MostrarPantallaTransaccionMayorMonto();
                    break;
                case 3:
                    MostrarPantallaPorcentajeDeCantidadesPorRubro();
                    break;
                case 4:
                    MostrarPantallaMontoRecaudadoTotal();
                    break;
                    break;
                default:
                    op = -1;
                    break;
            }
            #endregion

            #region solicitar opción
            if (op != -1)
                op = MostrarPantallaSolicitarOpcionMenu();
            #endregion
        }
        #endregion

        Console.WriteLine("Presione cualquier tecla para terminar el programa.");
        Console.ReadKey();
    }
}
