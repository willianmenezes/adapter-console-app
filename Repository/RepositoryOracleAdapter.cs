using System.Collections.Generic;
using PadraoAdapter.Domain;

namespace PadraoAdapter.Repository
{
    public class RepositoryOracleAdapter : IRepository
    {
        private readonly RepositoryOracle _repositoryOracle;

        public RepositoryOracleAdapter()
        {
            _repositoryOracle = new RepositoryOracle();
        }

        public void Adicionar(Produto produto)
        {
            _ = _repositoryOracle.Adicionar(produto);
        }

        public void Remover(Produto produto)
        {
            _repositoryOracle.Remover(produto.Id);
        }

        public void Editar(Produto produto)
        {
            _repositoryOracle.Editar(produto);
        }

        public IEnumerable<Produto> Buscar()
        {
            return _repositoryOracle.Buscar();
        }
    }
}