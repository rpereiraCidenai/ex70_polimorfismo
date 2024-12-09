using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex70_polimorfismo
{
    public class Gerente : Funcionario
    {
        public Gerente(string nome, string senha)
            : base(nome, senha)
        {
        }

        public void FecharCaixa()
        {
            Console.WriteLine(Nome +" fechou o caixa com sucesso.");
        }
    }
}
