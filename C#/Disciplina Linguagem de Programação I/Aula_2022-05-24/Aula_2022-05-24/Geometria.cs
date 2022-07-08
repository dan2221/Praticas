using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_2022_05_24
{
    class Geometria
    {
        public double Quadrado(double lado)
        {
            double area;
            area = lado * lado;
            return area;
        }

        public double Retangulo(double bas, double alt)
        {
            double area;
            area = bas * alt;
            return area;
        }

        public double Triangulo(double bas, double alt)
        {
            double area;
            area = bas * alt / 2;
            return area;
        }

        public double Trapezio(double basgrand, double baspeq, double alt)
        {
            double area;
            area = (basgrand + baspeq) * alt / 2;
            return area;
        }

        public double Fatorial (int num)
        {
            int i, fat=1;
            for (i = 1; i<= num; i++)
            {
                fat = fat * i;
            }
            return fat;
        }
    }
}
