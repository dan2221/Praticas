using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2___Console
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Exercício 2

            Monte um programa para calcular a área de Trapézio.
            */
            double area, basemenor, basemaior, alt;

            Console.Write("Digite a base menor:");

            // A conversão para double é necessária pois
            // o conteúdo que digitamos no console é do tipo string.
            basemenor = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a base maior:");
            basemaior = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a altura:");
            alt = Convert.ToDouble(Console.ReadLine());

            area = (basemaior + basemenor) * alt / 2;

            Console.Write("Área: " + Convert.ToString(area));

            // Gambiarra para pausar o sistema.
            Console.Read();
        }
    }
}
