using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteTecnico
{
    public class Questao3
    {
        public void Executar()
        {


            string json = File.ReadAllText("f:\\dados.json");
            List<FaturamentoDia> faturamento = JsonConvert.DeserializeObject<List<FaturamentoDia>>(json);

            int qtdDias = 0;
            double total = 0;

            double maior = 0;
            double menor = 0;

            foreach (var dia in faturamento)
            {
                if (dia.Valor > 0)
                {
                    qtdDias++;
                    total += dia.Valor;

                    if (maior == 0 || menor == 0)
                    {
                        maior = dia.Valor;
                        menor = dia.Valor;
                    }

                    if (dia.Valor > maior)
                    {
                        maior = dia.Valor;
                    }
                    if (dia.Valor < menor)
                    {
                        menor = dia.Valor;

                    }
                }
            }
            var dias = new List<int>();
            double media = total / qtdDias;

            Debug.WriteLine("Menor" + menor);
            Debug.WriteLine("Maior" + maior);

            foreach (var dia in faturamento)
            {
                if (dia.Valor > media)
                {
                    dias.Add(dia.Dia);
                }

            }
            Debug.WriteLine("Dias maior que a media:" + string.Join(",", dias));
        }
    }
}
