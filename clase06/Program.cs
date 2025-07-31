using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;

            Console.WriteLine("Cálculo del área de figuras geométricas");
            Console.WriteLine("1. Área del círculo");
            Console.WriteLine("2. Área del triángulo");
            Console.WriteLine("3. Área del rectángulo");
            Console.Write("Elige una opción (1-3): ");
            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    AreaCirculo(); // sin parámetros ni retorno
                    break;

                case 2:
                    Console.Write("Introduce la base del triángulo: ");
                    decimal baseTri = Convert.ToDecimal(Console.ReadLine());
                    Console.Write("Introduce la altura del triángulo: ");
                    decimal alturaTri = Convert.ToDecimal(Console.ReadLine());
                    AreaTriangulo(baseTri, alturaTri); // con parámetros, sin retorno
                    break;

                case 3:
                    Console.Write("Introduce el largo del rectángulo: ");
                    decimal largo = Convert.ToDecimal(Console.ReadLine());
                    Console.Write("Introduce el ancho del rectángulo: ");
                    decimal ancho = Convert.ToDecimal(Console.ReadLine());
                    decimal resultado = AreaRectangulo(largo, ancho); // con parámetros y retorno
                    Console.WriteLine("El área del rectángulo es: {0}", resultado);
                    break;

                default:
                    Console.WriteLine("Opción no válida.");
                    break;

            }
        }

        static void AreaCirculo()
        {
            Console.Write("Introduce el radio del círculo: ");
            decimal radio = Convert.ToDecimal(Console.ReadLine());
            decimal area = (decimal)Math.PI * radio * radio;
            Console.WriteLine("El área del círculo es: {0}", area);
        }

        static void AreaTriangulo(decimal b, decimal h)
        {
            decimal area = (b * h) / 2;
            Console.WriteLine("El área del triángulo es: {0}", area);
        }

        static decimal AreaRectangulo(decimal largo, decimal ancho)
        {
            return largo * ancho;
        }

    }
        }
}
