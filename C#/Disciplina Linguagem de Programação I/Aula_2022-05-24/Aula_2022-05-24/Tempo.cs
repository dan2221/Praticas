using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_2022_05_24
{
    class Tempo
    {
        int hora;
        int minuto;
        int segundo;

        // MÉTODO CONSTRUTOR ///////////////////////////////////////

        // • Sempre tem o nome da classe.
        // • Não tem retorno e não usa void.

        public Tempo()
        {
            hora = 0;
            minuto = 0;
            segundo = 0;
        }

        public Tempo(int xhora, int xmin, int xseg)
        {
            hora = xhora;
            minuto = xmin;
            segundo = xseg;
        }

        public string Imprimir()
        {
            return hora + " : " + minuto + " : " + segundo; 
        }
    }


}
