using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1___Console
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Exercício 1

            Monte um programa para calcular a área de Triângulo.
            */
            double area,bas,alt;

            Console.Write("Digite a base:");

            // A conversão para double é necessária pois
            // o conteúdo que digitamos no console é do tipo string.
            bas = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a altura:");
            alt = Convert.ToDouble(Console.ReadLine());

            area = (bas * alt) / 2;
            
            Console.Write("Área: "+ Convert.ToString(area));

            // Gambiarra para pausar o sistema.
            Console.Read();
        }
    }
}
