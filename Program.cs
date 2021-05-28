using System;
using PadraoAdapter.Domain;
using PadraoAdapter.Repository;

namespace PadraoAdapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var produto = new Produto()
            {
                Id = Guid.NewGuid(),
                Nome = "Camiseta",
                DataCadastro = DateTime.UtcNow
            };

            var clienteService = new ClienteService(new RepositoryOracleAdapter());

            clienteService.ProcessarProduto(produto);

            Console.ReadKey();
        }
    }
}


