using LojaVirtual.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace LojaVirtual.Repositories.Contracts
{
    public interface ICategoriaRepository
    {
        void Cadastrar(Categoria categoria);
        void Atulizar(Categoria categoria);
        void Excluir(int Id);
        Categoria ObterCategoria(int Id);
        IEnumerable<Categoria> ObterTodasCategorias();
        IPagedList<Categoria> ObterTodasCategorias(int? pagina);
    }
}
