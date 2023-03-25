using LanchesMacBurger.Models;
using LanchesMacBurger.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LanchesMacBurger.Controllers
{
    public class CarrinhoCompraController : Controller
    {
        private readonly ILancheRepository _lancheRepository;
        private readonly CarrinhoCompra _carrinhoCompra;

        public CarrinhoCompraController(ILancheRepository lancheRepository,CarrinhoCompra carrinhoCompra)
        {
            _lancheRepository = lancheRepository;
            _carrinhoCompra = carrinhoCompra;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
