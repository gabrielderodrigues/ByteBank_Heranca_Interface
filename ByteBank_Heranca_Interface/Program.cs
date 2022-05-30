using ByteBank_Heranca_Interface.Funcionarios;
using ByteBank_Heranca_Interface.Sistemas;
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
            // CalcularBonificacao();

            UsarSistema();

            Console.ReadLine();
        }

        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();

            Diretor roberta = new Diretor("159.753.389-04");
            roberta.Nome = "Roberta";
            roberta.Senha = "1234";

            GerenteDeConta camila = new GerenteDeConta("939.221.342-09");
            camila.Nome = "Camila";
            camila.Senha = "7890";

            sistemaInterno.Logar(roberta, "1234");
            sistemaInterno.Logar(roberta, "abc");
        }

        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            Designer pedro = new Designer("833.222.048-39");
            pedro.Nome = "Pedro";

            Diretor roberta = new Diretor("159.753.389-04");
            roberta.Nome = "Roberta";

            Auxiliar igor = new Auxiliar("981.198.345-66");
            igor.Nome = "Igor";

            GerenteDeConta camila = new GerenteDeConta("939.221.342-09");
            camila.Nome = "Camila";

            Desenvolvedor guilherme = new Desenvolvedor("454.235.634.98");

            gerenciadorBonificacao.Registrar(pedro);
            gerenciadorBonificacao.Registrar(roberta);
            gerenciadorBonificacao.Registrar(igor);
            gerenciadorBonificacao.Registrar(camila);
            gerenciadorBonificacao.Registrar(guilherme);

            Console.WriteLine("Total de bonificações do mês: " + gerenciadorBonificacao.GetTotalBonificacao());
        }
    }
}
