using ByteBank_Heranca_Interface.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_Heranca_Interface
{
    public class GerenciadorBonificacao
    {
        private double totalBonificacao;

        public void Registrar(Funcionario funcionario)
        {
            totalBonificacao += funcionario.GetBonificacao();
        }

        public void RegistrarDiretor(Diretor diretor)
        {
            totalBonificacao += diretor.GetBonificacao();
        }

        public double GetTotalBonificacao()
        {
            return totalBonificacao;
        }
    }
}
