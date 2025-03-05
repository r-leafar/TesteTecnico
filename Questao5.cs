using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteTecnico
{
    public class Questao5
    {

        public void Executar()
        {
            string entrada = "RAFAEL DIEGO SOUZA";
            StringBuilder nova = new StringBuilder();
            for (int i = entrada.Length - 1; i >= 0; i--)
            {
                nova.Append(entrada[i]);

            }
            Debug.WriteLine(nova.ToString());
        }
    }
}
