using System;

namespace HerancaPolimorfismo.Entites
{
    class FuncionarioTerceirizado : Funcionario //Herdando da classe "Funcionário"
    {
        //Propriedade automatica prop
        public double DespesaAdicional { get; set; }

        //=============================================================================================================================

        //Construtor da classe com herança da super classe
        public FuncionarioTerceirizado(string nome, int horasTrabalhadas, double valorPorHora, double despesaAdicional) : base(nome, horasTrabalhadas, valorPorHora)
        {
            DespesaAdicional = despesaAdicional;
        }
        //=============================================================================================================================

        //Metodo sendo sobrescrito com a palavra "override"
        public override double Pagamento()
        {
            return base.Pagamento() + DespesaAdicional * 1.10;
        }
        //=============================================================================================================================
    }
}
