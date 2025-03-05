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

            int qtdDias = faturamento.FindAll(x => x.Valor > 0).Count();

            double maior = faturamento.FindAll(x => x.Valor > 0).Max(x => x.Valor);

            double menor = faturamento.FindAll(x => x.Valor > 0).Min(x => x.Valor);

            double total = faturamento.FindAll(x => x.Valor > 0).Sum(x => x.Valor);

            var dias = new List<int>();
            double media = total / qtdDias;

            Debug.WriteLine("Menor" + menor);
            Debug.WriteLine("Maior" + maior);

            faturamento.FindAll(x => x.Valor > media).Select(faturamento => faturamento.Dia).ToList().ForEach(x => dias.Add(x));

            Debug.WriteLine("Dias maior que a media:" + string.Join(",", dias));
        }
    }
}
