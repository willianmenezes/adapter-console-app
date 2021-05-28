using System;
using PadraoAdapter.Domain;
using PadraoAdapter.Repository;

namespace PadraoAdapter
{
    public class ClienteService
    {
        private readonly RepositoryOracleAdapter _repositoryOracleAdapter;

        public ClienteService(RepositoryOracleAdapter repositoryOracleAdapter)
        {
            _repositoryOracleAdapter = repositoryOracleAdapter;
        }

        public void ProcessarProduto(Produto produto)
        {
            // processamento de qualquer que seja sua regra de negócio
            
            if (produto == null)
            {
                throw new Exception("Produto inválido");
            }

            if (produto.DataCadastro > DateTime.UtcNow)
            {
                throw new Exception("Data de cadastro inválida");
            }
            
            // cadastrando o produto na base de dados pelo atraves do repository
            
            _repositoryOracleAdapter.Adicionar(produto);
        }
    }
}