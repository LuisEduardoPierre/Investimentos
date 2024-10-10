using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Investimentos.API.Modelos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Investimentos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InvestimentosController : ControllerBase
    {

        public IEnumerable<Investimento> _investimento = new Investimento[]{
                new Investimento(){
                InvestimentoId = 1,
                tickerAtivo = "14526",
                Quantia = 5 ,
                Preco = 597.80,
                dataInvestimento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy")
            },
             new Investimento(){
                InvestimentoId = 2,
                tickerAtivo = "16526",
                Quantia = 2 ,
                Preco = 609.70,
                dataInvestimento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy")
            }
                };

        public InvestimentosController()
        {

        }

        [HttpGet]
        public IEnumerable<Investimento> Get()
        {
           return _investimento;
        }
        [HttpGet("{id}")]
        public IEnumerable<Investimento> GetById(int id)
        {
           return _investimento.Where(Investimento => Investimento.InvestimentoId == id);
        }

        [HttpPost]
        public string Post()
        {
            return "Exemplo post";
        }

        [HttpPut("{id}")]
        public string Put()
        {
            return "Exemplo put";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return "Exemplo Delete";
        }
    }
}
