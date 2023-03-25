using LanchesMacBurger.Models;
using System.Collections.Generic;

namespace LanchesMacBurger.Repositories.Interfaces
{
    public interface ILancheRepository
    {
        IEnumerable<Lanche> Lanches { get; }

        IEnumerable<Lanche> LanchesPreferidos { get; }

        Lanche GetLancheById(int lancheid);
    }
}
