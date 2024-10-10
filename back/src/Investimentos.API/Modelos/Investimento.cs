using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Investimentos.API.Modelos
{
    public class Investimento
    {
        public int InvestimentoId { get; set; }
        public string tickerAtivo { get; set; }
        public int Quantia { get; set; }
        public double Preco { get; set; }
        public string dataInvestimento { get; set; }
    }
}