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

            try // Tentativa
            {
                // Preenchendo os dados do cliente:
                cliente.Id = Guid.NewGuid();

                Console.Write("Informe o nome do cliente.....: ");
                cliente.Nome = Console.ReadLine();

                Console.Write("Informe o email do cliente....: ");
                cliente.Email = Console.ReadLine();

                Console.Write("Informe o cpf do cliente......: ");
                cliente.Cpf = Console.ReadLine();

                Console.Write("Informe a data de nascimento..: ");
                cliente.DataNascimento = DateTime.Parse(Console.ReadLine());

                // Imprimindo os campos
                // cw -> 2x[tab]
                Console.WriteLine("\nDADOS DO CLIENTE:");
                Console.WriteLine($"Id do cliente.....: {cliente.Id}");
                Console.WriteLine($"Nome..............: {cliente.Nome}");
                Console.WriteLine($"Email.............: {cliente.Email}");
                Console.WriteLine($"Cpf...............: {cliente.Cpf}");
                Console.WriteLine($"Data de Nascimento: {cliente.DataNascimento}");
            }
            catch ( Exception e ) // Capturar a exceção (erro)
            {
                Console.WriteLine("\n Falha ao cadastrar o cliente! \n");
                Console.WriteLine($"Erro: {e.Message}");
            }

            // Pausar o prompt de comandos
            Console.ReadKey();
        }
    }
}