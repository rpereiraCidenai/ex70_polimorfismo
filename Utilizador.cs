using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex70_polimorfismo
{
    public class Utilizador
    {
        public string Nome { get; set; }
        public string Senha { get; set; }

        public Utilizador(string nome, string senha)
        {
            Nome = nome;
            Senha = senha;
        }

        public virtual void ExibirInformacoes()
        {
            Console.WriteLine("Nome: "+Nome+" senha: "+Senha);
        }
    }
}
