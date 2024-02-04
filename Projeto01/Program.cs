using Projeto01.Entities;

// Definindo o namespace da classe (localização)
namespace Projeto01
{
    // Declaração da classe
    public class Program
    {
        // Método para execução / inicialização do projeto
        public static void Main(string[] args)
        {
            // Imprimir mensagem (Console do DOS)
            Console.WriteLine("\n *** CADASTRO DE CLIENTES *** \n");

            // Criando um objeto da classe Cliente (variável de instância)
            var cliente = new Cliente();

            // Preenchendo os dados do cliente:
            cliente.Id = Guid.NewGuid();
            cliente.Nome = "Lucas Mateus Midão Fernandes";
            cliente.Email = "mateusmidao@gmail.com";
            cliente.Cpf = "123.456.789-00";
            cliente.DataNascimento = new DateTime(1996, 1, 21);

            // Imprimindo os campos
            // cw -> 2x[tab]
            Console.WriteLine("\nDADOS DO CLIENTE:");
            Console.WriteLine($"Id do cliente.....: {cliente.Id}");
            Console.WriteLine($"Nome..............: {cliente.Nome}");
            Console.WriteLine($"Email.............: {cliente.Email}");
            Console.WriteLine($"Cpf...............: {cliente.Cpf}");
            Console.WriteLine($"Data de Nascimento: {cliente.DataNascimento}");

            // Pausar o prompt de comandos
            Console.ReadKey();
        }
    }
}