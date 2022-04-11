using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_Heranca_Interface.Funcionarios
{
    public class Funcionario
    {
        private int tipoFuncionario { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public double Salario { get; set; }

        public virtual double GetBonificacao()
        { 
            return Salario * 0.10;
        }
    }
}
