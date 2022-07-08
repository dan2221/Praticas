using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_3___Console
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Exercício 3

            Monte um programa para calcular volume do cilíndro.
                              */
            double volume, raio, alt, pi;

            // Método que retorna o valor de PI.
            pi = Math.PI;

            Console.Write("Digite o Raio:");

            // A conversão para double é necessária pois
            // o conteúdo que digitamos no console é do tipo string.
            raio = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a altura:");
            alt = Convert.ToDouble(Console.ReadLine());

            // Método Pow faz a potenciação do número
            volume = pi * Math.Pow(raio, 2) * alt;

            Console.Write("Área: " + Convert.ToString(volume));

            // Gambiarra para pausar o sistema.
            Console.Read();
        }
    }
}
