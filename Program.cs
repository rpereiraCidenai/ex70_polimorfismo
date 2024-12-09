namespace Ex70_polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Criar objetos das classes
            Cliente cliente = new Cliente("João", "senha123", "Rua A, 123", "912345678");
            Funcionario funcionario = new Funcionario("Maria", "senha456");
            Gerente gerente = new Gerente("Carlos", "senha789");

            // Exibir informações do cliente
            Console.WriteLine("Informações do Cliente:");
            cliente.ExibirInformacoes();
            Console.WriteLine();

            // Funcionário regista uma venda
            Console.WriteLine("Ações do Funcionário:");
            funcionario.RegistarVenda();
            Console.WriteLine();

            // Gerente fecha o caixa
            Console.WriteLine("Ações do Gerente:");
            gerente.FecharCaixa();


            ////Saida da consola

            //Informações do Cliente:
            //Nome: Rua A, 123 e senha e: 912345678
            //Endereço: João
            //Telefone: senha123

            //Ações do Funcionário:
            //                registo de venda
            //Nome: Maria e senha e:senha456

            //Ações do Gerente:
            //                registo de venda
            //Nome: Maria e senha e:senha456
            //fecho de caixa




        }
    }
}
