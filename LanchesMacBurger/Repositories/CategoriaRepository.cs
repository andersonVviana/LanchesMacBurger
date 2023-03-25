using LanchesMacBurger.Context;
using LanchesMacBurger.Models;
using LanchesMacBurger.Repositories.Interfaces;
using System.Collections.Generic;

namespace LanchesMacBurger.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _context;

        public CategoriaRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Categoria> Categorias => _context.Categorias;
    }
}
