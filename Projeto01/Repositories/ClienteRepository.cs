using Projeto01.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto01.Repositories
{
    // Classe para exercer o papel de repositório de dados de cliente
    public class ClienteRepository
    {
        // Método (função) para receber os dados de um objeto cliente
        // e grava-los em um arquivo de extensão .txt
        public void GravarArquivo(Cliente cliente)
        {
            // Definindo o nome do arquivo.
            var path = $"d:\\temp\\csharp\\webdeveloper\\cliente_{cliente.Id}.txt";

            // Abrindo o arquivo em modo de escrita
            var streamWriter = new StreamWriter(path);

            // Escrevendo o conteúdo do arquivo
            streamWriter.WriteLine($"ID..............: {cliente.Id}");
            streamWriter.WriteLine($"NOME............: {cliente.Nome}");
            streamWriter.WriteLine($"EMAIL...........: {cliente.Email}");
            streamWriter.WriteLine($"CPF.............: {cliente.Cpf}");
            streamWriter.WriteLine($"DATA NASCIMENTO.: {cliente.DataNascimento}");

            // Salvando e fechando o arquivo
            streamWriter.Flush();
            streamWriter.Close();
        }
    }
}
