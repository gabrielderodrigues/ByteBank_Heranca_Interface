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

            Funcionario carlos = new Funcionario(2000, "544.653.987-85");
            carlos.Nome = "Carlos";

            carlos.AumentarSalario();
            Console.WriteLine("Novo salário do Carlos: " + carlos.Salario);

            Console.WriteLine(Funcionario.TotalFuncionarios);

            gerenciador.Registrar(carlos);

            Diretor roberto = new Diretor(5000, "454.856.523-90");
            roberto.Nome = "Roberto";

            roberto.AumentarSalario();
            Console.WriteLine("Novo salário do Roberto: " + roberto.Salario);

            Console.WriteLine(Funcionario.TotalFuncionarios);

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
