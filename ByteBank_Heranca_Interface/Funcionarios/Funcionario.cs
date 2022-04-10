using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_Heranca_Interface.Funcionarios
{
    public class Funcionario
    {
        // 1 - Diretor
        // 2 - Assistente
        private int tipoFuncionario { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public double Salario { get; set; }
        
        public Funcionario(int tipoFuncionario)
        {
            tipoFuncionario = tipoFuncionario;
        }

        public double GetBonificacao()
        {
            if (tipoFuncionario == 1)
            {
                return Salario;
            }

            return Salario * 0.10;
        }
    }
}
