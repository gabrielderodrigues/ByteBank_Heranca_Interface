using ByteBank_Heranca_Interface.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_Heranca_Interface
{
    public class Program
    {
        public static void Main(string[] args)
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Funcionario carlos = new Funcionario();
            carlos.Nome = "Carlos";
            carlos.CPF = "544.653.987-85";
            carlos.Salario = 2000;

            gerenciador.Registrar(carlos);

            Diretor roberto = new Diretor();
            roberto.Nome = "Roberto";
            roberto.CPF = "454.856.523-90";
            roberto.Salario = 5000;

            Funcionario robertoTeste = roberto;

            Console.WriteLine("Bonificação de uma referência de Diretor: " + roberto.GetBonificacao());
            Console.WriteLine("Bonificação de uma referência de Funcionario: " + robertoTeste.GetBonificacao());

            gerenciador.Registrar(roberto);

            Console.WriteLine(carlos.Nome);
            Console.WriteLine(carlos.GetBonificacao());

            Console.WriteLine();

            Console.WriteLine(roberto.Nome);
            Console.WriteLine(roberto.GetBonificacao());

            Console.WriteLine();

            Console.WriteLine("Total de bonificações: " + gerenciador.GetTotalBonificacao());

            Console.ReadLine();
        }
    }
}
