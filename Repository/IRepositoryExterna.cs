using System;
using System.Collections.Generic;
using PadraoAdapter.Domain;

namespace PadraoAdapter.Repository
{
    public interface IRepositoryExterna
    {
        Produto Adicionar(Produto produto);
        void Remover(Guid id);
        void Editar(Produto produto);
        IEnumerable<Produto> Buscar();
    }
}

