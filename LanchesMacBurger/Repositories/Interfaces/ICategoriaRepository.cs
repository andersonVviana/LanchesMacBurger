using LanchesMacBurger.Models;
using System.Collections.Generic;

namespace LanchesMacBurger.Repositories.Interfaces
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> Categorias { get; }
    }
}
