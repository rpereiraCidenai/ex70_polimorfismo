using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex70_polimorfismo
{
    public class Funcionario : Utilizador
    {
        public Funcionario(string nome, string senha)
            : base(nome, senha)
        {
        }

        public void RegistarVenda()
        {
            Console.WriteLine(Nome +" registou uma venda com sucesso.");
        }
    }
}
