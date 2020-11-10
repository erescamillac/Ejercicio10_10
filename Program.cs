using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10_10
{
    
    class Program
    {
       
        /*
         * @author:  Erick Escamilla Charco
         */
        static double Area(string tipoFigura)
        {
            double area = 0.0;
            switch (tipoFigura.ToLower()) {
                case "cuadrado":
                    double longitudLado;
                    Console.WriteLine("Cálculo del área de un Cuadrado.");
                    Console.WriteLine("Ingrese la longitud del lado del cuadrado: ");
                    longitudLado = Double.Parse(Console.ReadLine());
                    area = Math.Pow(longitudLado, 2);
                    break;
                case "triangulo":
                    double longBase, altura;
                    Console.WriteLine("Cálculo del área de un Triángulo.");
                    Console.WriteLine("Ingrese la longitud de la base: ");
                    longBase = Double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la altura del Triángulo: ");
                    altura = Double.Parse(Console.ReadLine());
                    area = (longBase * altura) / 2;
                    break;
                case "circulo":
                    double radio;
                    Console.WriteLine("Cálculo del área de un círculo.");
                    Console.WriteLine("Ingrese el valor del radio: ");
                    radio = Double.Parse(Console.ReadLine());
                    area = Math.PI * Math.Pow(radio, 2);
                    break;
                default:
                    Console.WriteLine("La figura [{0}] NO está soportada.", tipoFigura);
                    area = -1.0;
                    break;
            }
            return area;
        }
        static void Main(string[] args)
        {
            char continuar;
            string figura;
            double area;
            do {
                Console.Clear();
                Console.WriteLine("##--Cálculo de áreas--##");
                Console.WriteLine("Tipo de figura para el que desea calcular el área (cuadrado/triangulo/circulo): ");
                figura = Console.ReadLine();
                area = Area(figura);
                Console.WriteLine("El área de la figura [{0}] es [{1}].", figura, area);
                Console.WriteLine("\t¿Desea calcular el área de otra figura? [y/n]: ");
                continuar = Console.ReadKey().KeyChar;
            } while (Char.ToLower(continuar).Equals('y'));
        }
    }
}
