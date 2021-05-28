using System;
using System.Collections.Generic;
using PadraoAdapter.Domain;

namespace PadraoAdapter.Repository
{
    public class RepositorySQLServer: IRepository
    {
        public void Adicionar(Produto produto)
        {
            Console.WriteLine("Adicionando o produto no SQL SERVER");
        }

        public void Remover(Produto produto)
        {
            Console.WriteLine("Removendo o produto do SQL SERVER");
        }

        public void Editar(Produto produto)
        {
            Console.WriteLine("Editando o produto no SQL SERVER");
        }

        public IEnumerable<Produto> Buscar()
        {
            Console.WriteLine("Retornando uma lista de produtos que estão no SQL SERVER");
            return null;
        }
    }
}

