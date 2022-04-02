using System;
using System.Globalization;
using System.Collections.Generic;
using HerancaPolimorfismo.Entites;

namespace HerancaPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            //Criando uma Lista do tipo funcionário
            List<Funcionario> Lfuncionarios = new List<Funcionario>();

            //Tratamento de erros padrão
            try
            {
                //=============================================================================================================================
                //Pedindo para digitar a quantidade de funcionários
                Console.Write("Quantos funcionarios irão trabalhar?: ");
                int n = int.Parse(Console.ReadLine());
                //=============================================================================================================================

                //Laço for que conta até n
                for (int i = 1; i <= n; i++)
                {
                    //Perguntando se o funcionário é terceirizado
                    Console.Write("Este funcinário é terceirizado? y/n: ");
                    char resp = char.Parse(Console.ReadLine());

                    //Mostrando a mensagem dados do funcionário na ordem que foi digitado
                    Console.WriteLine($"Dados do funcionário n°{i}");

                    //Coletando o nome do funcionário
                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();

                    //Coletando a quantidade de horas que o funcionário trabalhou
                    Console.Write("Horas: ");
                    int horas = int.Parse(Console.ReadLine());

                    //Coletando o valor que sera pago por hora trabalhada
                    Console.Write("Valor por hora: ");
                    double valorPorHora = double.Parse(Console.ReadLine(), CI);

                    //=============================================================================================================================

                    //Verificando a resposta
                    if (resp == 'y')
                    {
                        //Se a resposta for verdadeira executa essa parte do codigo
                        Console.Write("Despesa adicional: ");
                        double despesaAdicional = double.Parse(Console.ReadLine(), CI);
                        Lfuncionarios.Add(new FuncionarioTerceirizado(nome, horas, valorPorHora, despesaAdicional));
                    }
                    else
                    {
                        //Se a resposta for falsa executa essa parte do codigo
                        Lfuncionarios.Add(new Funcionario(nome, horas, valorPorHora));
                    }

                    //Pula linha
                    Console.WriteLine();
                }

                //Mostrando a mensagem Pagamentos:
                Console.WriteLine("Pagamentos:");

                //laço foreach que percorre dentro da lista
                foreach (Funcionario funcionario in Lfuncionarios)
                {
                    //Mostrando o nome e o pagamento de cada categoria de funcionário
                    Console.WriteLine(funcionario.Nome + " - R$" + funcionario.Pagamento().ToString("F2", CI));
                }
            }
            catch (Exception ex)
            {
                //Mostrando a mensagem padrã do Exception
                Console.WriteLine(ex.Message);
            }
            
            
        }
    }
}
