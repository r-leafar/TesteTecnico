using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteTecnico
{
    public  class Questao1
    {
        public int Executar()
        {
            int INDICE = 13;
            int SOMA = 0;
            int K = 0;

            while (K < INDICE)
            {
                K = K + 1;
                SOMA = SOMA + K;
            }
            Debug.WriteLine("Soma: " + SOMA);
            return SOMA;
        }

    }
}
