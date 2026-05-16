using System;

namespace Ejercicio1;

internal class Program
{
    static void Main(string[] args)
    {
        int valor = 0;
        int cantidad = 0;
        int acumulador = 0;
        int maximo=0, minimo=0;
        double promedio = 0d;

        #region solicitar cantidad de ingresos
        Console.WriteLine("Ingrese la cantidad de valores aprocesar");
        cantidad = Convert.ToInt32(Console.ReadLine());
        #endregion

        #region iterar ingresos de valores
        for (int n=1;n<cantidad;n++)
        {
            Console.WriteLine("Ingrese valor");
            valor = Convert.ToInt32(Console.ReadLine());

            acumulador += valor;

            if (n==1 || valor > maximo)
            {
                maximo = valor;
            }

            if (n == 1 || valor < minimo)
            {
                minimo = valor;
            }
        }
        #endregion

        #region verificar si hay números y calcular promedio
        if (cantidad > 0)
        {
            promedio = 1.0*valor / cantidad;
        }
        #endregion

        #region mostrar resultados
        Console.WriteLine("maximo: " + maximo);
        Console.WriteLine("minimo: " + minimo);
        if (cantidad > 0)
            Console.WriteLine("promedio: "+promedio);
        #endregion

        Console.WriteLine("Presione cualquier tecla para terminar el programa.");
        Console.ReadKey();
    }
}
