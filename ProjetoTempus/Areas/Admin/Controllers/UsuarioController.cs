using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProjetoTempus.AccessData.Data.Repository.IRepository;
using ProjetoTempus.Utility;

namespace ProjetoTempus.Areas.Admin.Controllers
{
    [Authorize(Roles = SD.Admin)]
    [Area("Admin")]
    public class UsuarioController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public UsuarioController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            var claimsIdentity = (ClaimsIdentity)this.User.Identity;
            var claims = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
            if(claims == null)
            {
                return RedirectToAction("Index","Home");
            }
            return View(_unitOfWork.Usuario.GetAll(u=>u.Id != claims.Value));
        }

        public IActionResult Lock(string id)
        {
            if(id == null)
            {
                return NotFound();
            }

            _unitOfWork.Usuario.LockUser(id);

            return RedirectToAction(nameof(Index));
        }

        public IActionResult UnLock(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            _unitOfWork.Usuario.UnLockUser(id);

            return RedirectToAction(nameof(Index));
        }
    }
}
