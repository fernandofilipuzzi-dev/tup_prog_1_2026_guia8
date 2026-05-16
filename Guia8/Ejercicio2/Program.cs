
namespace Ejercicio2;

internal class Program
{
    #region resolución del problema
    static int edad0;
    static int edad1;
    static int edad2;
    static int edad3;
    static double monto;
    static double porcentaje0;
    static double porcentaje1;
    static double porcentaje2;
    static double porcentaje3;
    static double monto0;
    static double monto1;
    static double monto2;
    static double monto3;

    static void RegistrarMontoARepartir(double monto)
    {
        Program.monto = monto;
    }

    static void RegistrarEdad(int edad, int nroNiña)
    {
        switch (nroNiña)
        { 
            case 0: edad0 = edad; break;
            case 1: edad1 = edad; break;        
            case 2: edad2 = edad; break;
            case 3: edad3 = edad; break;
        }
    }

    static void CalcularMontosYPorcentajesARepartir()
    {
        double edadTotal=edad0+edad1+edad2+edad3;
        porcentaje0 = 1.0 * edad0 / edadTotal * 100;
        porcentaje1 = 1.0 * edad1 / edadTotal * 100;
        porcentaje2 = 1.0 * edad2 / edadTotal * 100;
        porcentaje3 = 1.0 * edad3 / edadTotal * 100;
        monto0 = monto * porcentaje0/100;
        monto1 = monto * porcentaje1/100;
        monto2 = monto * porcentaje2/100;
        monto3 = monto * porcentaje3/100;
    }

    #endregion

    #region metodos de impresión de pantallas
    static int MostrarPantallaSolicitarOpcionMenu()
    {
        Console.Clear();
        Console.WriteLine("Ingrese las siguiente opciones:\n\n");
        Console.WriteLine("1- Iniciar monto a repartir");
        Console.WriteLine("2- Solicitar Edad Por niña");
        Console.WriteLine("3- Mostrar monto y porcentajes de las niñas");            
        Console.WriteLine("(otro)- Salir.");
        int op = Convert.ToInt32(Console.ReadLine());
        return op;
    }

    static void MostrarPantallaSolicitarMontoARepartir()
    {
        Console.Clear();
        Console.WriteLine("monto a repartir: \n\n");

        double montoARepartir=Convert.ToDouble(Console.ReadLine());

        RegistrarMontoARepartir(montoARepartir);

        Console.WriteLine("\n\n\nPresione una tecla para continuar");
        Console.ReadKey();
    }

    static void MostrarPantallaSolicitarEdadesNiñas()
    {
        Console.Clear();
        Console.WriteLine("Edades de las niñas:\n\n");

        for (int nro = 0; nro < 4; nro++)
        {
            Console.WriteLine("Entre la edad de la niña número: "+(nro+1)+"\n");
            int edad = Convert.ToInt32(Console.ReadLine());
            RegistrarEdad(edad, nro);
        }
    }
   
    static void MostrarPantallaCalcularMostrarMontoYPorcentajePorNiña()
    {
        Console.Clear();
        Console.WriteLine("Reparto de dinero: \n\n");

        CalcularMontosYPorcentajesARepartir();

        Console.WriteLine($"Niña 1 ({edad0}), Porcentaje: {porcentaje0:f2}, monto: ${monto0:f2}");
        Console.WriteLine($"Niña 2 ({edad1}), Porcentaje: {porcentaje1:f2}, monto: ${monto1:f2}");
        Console.WriteLine($"Niña 3 ({edad2}), Porcentaje: {porcentaje2:f2}, monto: ${monto2:f2}");
        Console.WriteLine($"Niña 4 ({edad3}), Porcentaje: {porcentaje3:f2}, monto: ${monto3:f2}");

        Console.WriteLine("\n\n\nPresione una tecla para volver al menú principal");
        Console.ReadKey();
    }
    
    #endregion

    static void Main(string[] args)
    {
        MostrarPantallaSolicitarMontoARepartir();

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
                    MostrarPantallaSolicitarMontoARepartir();
                    break;
                case 2:
                    MostrarPantallaSolicitarEdadesNiñas();
                    break;
                case 3:
                    MostrarPantallaCalcularMostrarMontoYPorcentajePorNiña();
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
