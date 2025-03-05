using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteTecnico
{
    public class Questao4
    {

        public void Executar()
        {
        
        double SP = 67836.43;
        double RJ = 36678.66;
        double MG = 29229.88;
        double ES = 27165.48;
        double OUTROS = 19849.53;

        double total = SP + RJ + MG + ES + OUTROS;

        Debug.WriteLine("SP %:" + Math.Round((SP / total) * 100), 2);
        Debug.WriteLine("RJ %:" + Math.Round((RJ / total) * 100), 2);
        Debug.WriteLine("MG %:" + Math.Round((MG / total) * 100), 2);
        Debug.WriteLine("ES %:" + Math.Round((ES / total) * 100), 2);
        Debug.WriteLine("OUTROS %:" + Math.Round((OUTROS / total) * 100), 2);

            
        }
    }
}
