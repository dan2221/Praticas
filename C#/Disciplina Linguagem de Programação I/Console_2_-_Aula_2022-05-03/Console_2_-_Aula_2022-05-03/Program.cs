using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_2___Aula_2022_05_03
{
    class Program
    {
        static void Main(string[] args)
        {
            double dist, tempo, velocidade;

            Console.Write("Digite a distância:");
            dist = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o tempo:");
            tempo = Convert.ToDouble(Console.ReadLine());

            velocidade = dist / tempo;

            Console.WriteLine("A velocidade média é: " + velocidade);
            Console.WriteLine("Percorrendo {0} km em {1} horas, a velocidade média é de {2}",dist,tempo,velocidade);
            Console.Read();
        }
    }
}
