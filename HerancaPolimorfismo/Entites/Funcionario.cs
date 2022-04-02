using System;
namespace HerancaPolimorfismo.Entites
{
    class Funcionario
    {
        //Propriedades automaticas auto prop
        public string Nome { get; set; }
        public int HorasTrabalhadas { get; set; }
        public double ValorPorHora { get; set; }
        //=============================================================================================================================

        //Construtor vazio
        public Funcionario()
        {
        }
        //=============================================================================================================================

        //Construtor da classe
        public Funcionario(string nome, int horasTrabalhadas, double valorPorHora)
        {
            Nome = nome;
            HorasTrabalhadas = horasTrabalhadas;
            ValorPorHora = valorPorHora;
        }
        //=============================================================================================================================

        //Metodo que pode ser sobrescrito por causa da palavra "virtual"
        public virtual double Pagamento()
        {
            return HorasTrabalhadas * ValorPorHora;
        }
        //=============================================================================================================================
    }
}
