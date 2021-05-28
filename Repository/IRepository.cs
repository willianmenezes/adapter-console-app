using System.Collections.Generic;
using PadraoAdapter.Domain;

namespace PadraoAdapter.Repository
{
    public interface IRepository
    {
        void Adicionar(Produto produto);
        void Remover(Produto produto);
        void Editar(Produto produto);
        IEnumerable<Produto> Buscar();
    }
}

