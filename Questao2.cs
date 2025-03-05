using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteTecnico
{
    public  class Questao2
    {

        static int Fibonacci(int n)
        {
            if (n <= 1)
                return n;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
        public string Executar(int numero)
        {
            int[] valores = { 0, 1, 2, 3, 5, 8, 13, 21, 34 };

            if (numero >= 0)
            {
                if (valores.Any(x => x == numero))
                {
                    return "Pertence a sequencia de fibonacci";
                }
            }

            int contador = 10;
            int valor = 0;

            while (valor < numero)
            {
                valor = Fibonacci(contador);
                contador++;
            }

            if (valor == numero)
            {
                return "Pertence a sequencia de fibonacci";
            }


            return "Não faz parte da sequencia de fibonacci";
        }
    }


}
