using System;

namespace CapyFinPlan.Domain.Model.Modelos.Ativos
{
    public class Acao : AtivoBase
    {
        public Acao(string codigo, DateTime dataCompra, decimal valorCompra)
            : base(codigo, dataCompra, valorCompra)
        {

        }

        public int Quantidade { get; set; }
    }
}