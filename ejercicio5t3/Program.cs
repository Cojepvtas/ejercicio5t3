using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio5t3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el número de lados del polígono regular:");
            int numLados = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese la longitud de un lado del polígono regular:");
            double longitudLado = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("¿Qué desea calcular? (Ingrese 'perimetro' o 'area'):");
            string opcion = Console.ReadLine().ToLower();

            switch (opcion)
            {
                case "perimetro":
                    double perimetro = CalcularPerimetro(numLados, longitudLado);
                    Console.WriteLine($"El perímetro del polígono regular es: {perimetro}");
                    break;
                case "area":
                    double area = CalcularArea(numLados, longitudLado);
                    Console.WriteLine($"El área del polígono regular es: {area}");
                    break;
                default:
                    Console.WriteLine("Opción inválida. Por favor, ingrese 'perimetro' o 'area'.");
                    break;
            }

            Console.WriteLine("Presione cualquier tecla para salir...");
            Console.ReadKey();
        }

        static double CalcularPerimetro(int numLados, double longitudLado)
        {
            return numLados * longitudLado;
        }

        static double CalcularArea(int numLados, double longitudLado)
        {
            double apotema = longitudLado / (2 * Math.Tan(Math.PI / numLados));
            double area = (numLados * longitudLado * apotema) / 2;
            return area;
        }

    }
}
