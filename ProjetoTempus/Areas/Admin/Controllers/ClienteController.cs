using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProjetoTempus.AccessData.Data.Repository.IRepository;
using ProjetoTempus.Models;
using ProjetoTempus.Utility;

namespace ProjetoTempus.Areas.Admin.Controllers
{
    [Authorize]
    [Area("Admin")]
    public class ClienteController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public ClienteController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
