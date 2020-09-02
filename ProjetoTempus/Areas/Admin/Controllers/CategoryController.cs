using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProjetoTempus.AccessData.Data.Repository.IRepository;
using ProjetoTempus.Models;
using ProjetoTempus.Utility;

namespace ProjetoTempus.Areas.Admin.Controllers
{
    [Authorize]
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public CategoryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Upsert(int? id)
        {
            Category category = new Category();
            if(id == null)
            {
                return View(category);
            }

            category = _unitOfWork.Category.Get(id.GetValueOrDefault());
            if(category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpSert( Category category)
        {
            if(ModelState.IsValid)
            {
                if(category.Id == 0)
                {
                    _unitOfWork.Category.Add(category);
                }
                else
                {
                    _unitOfWork.Category.Update(category);
                }
                _unitOfWork.Save();
                return RedirectToAction(nameof(Index));
            }

            return View(category);
        }

        #region API Calls
        [HttpGet]
        public IActionResult GetAll()
        {
            //return Json( new { data = _unitOfWork.Category.GetAll() });
            return Json(new { data = _unitOfWork.USP_Call.ReturnList<Category>(SD.Usp_GetAllCategory, null)});
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var objFromDB = _unitOfWork.Category.Get(id);
            if (objFromDB == null)
            {
                return Json(new { success = false, message = "Error while was deleting" });
            }

            _unitOfWork.Category.Remove(objFromDB);
            _unitOfWork.Save();
            return Json(new { success = true, message = "Deleted Successful" });
        }
        #endregion
    }
}
