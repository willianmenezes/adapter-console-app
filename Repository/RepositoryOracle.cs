using System;
using System.Collections.Generic;
using PadraoAdapter.Domain;

namespace PadraoAdapter.Repository
{
    public class RepositoryOracle :IRepositoryExterna
    {
        public Produto Adicionar(Produto produto)
        {
            Console.WriteLine("Cadastrando no Oracle");
            return produto;
        }

        public void Remover(Guid id)
        {
            Console.WriteLine("Removendo o produto no oracle");
        }

        public void Editar(Produto produto)
        {
            Console.WriteLine("Editando o produto no oracle");
        }

        public IEnumerable<Produto> Buscar()
        {
            Console.WriteLine("Buscando os dados no oracle");
            return null;
        }
    }
}

