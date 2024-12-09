using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex70_polimorfismo
{
   
        public class Cliente : Utilizador
        {
            public string Endereco { get; set; }
            public string Telefone { get; set; }

            public Cliente(string nome, string senha, string endereco, string telefone)
                : base(nome, senha)
            {
                Endereco = endereco;
                Telefone = telefone;
            }

            public override void ExibirInformacoes()
            {
                base.ExibirInformacoes();
                Console.WriteLine("Endereço: "+Endereco);
                Console.WriteLine("Telefone: "+Telefone);
            }
        }
    
}
