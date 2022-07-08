using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_2022_04_26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Método de print que pula linha");
            Console.Write("Método de print que não pula linha\n");

            int tempo = 5;
            int minutos = 30;
            int segundos = 20;

            // concatenar
            Console.WriteLine("A viagem durou " + tempo + " horas.");

            // concatenar sem quebrar aspas
            Console.WriteLine("A viagem durou {0} horas.",tempo);

            // O número dentro das chaves indica o índice da variável a ser concatenada.
            Console.WriteLine("A viagem durou {0} horas, {1} minutos e {2} segundos.", tempo, minutos, segundos);

            // Método necessário no final de cada aplicação de console.
            Console.Read();
        }
    }
}
