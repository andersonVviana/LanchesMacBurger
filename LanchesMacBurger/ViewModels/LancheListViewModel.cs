using LanchesMacBurger.Models;
using System.Collections.Generic;

namespace LanchesMacBurger.ViewModels
{
    public class LancheListViewModel
    {
        public IEnumerable<Lanche> Lanches { get; set; }

        public string CategoriaAtual { get; set; }

    }
}
