using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProjetoTempus.AccessData.Data.Repository.IRepository;
using ProjetoTempus.DataAccess.Data;
using ProjetoTempus.Models;
using ProjetoTempus.Utility;

namespace ProjetoTempus.Areas.Admin.Controllers
{
    [Authorize]
    [Area("Admin")]
    public class WebImagesController : Controller
    {
        private readonly ApplicationDbContext _db;

        public WebImagesController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Upsert(int? id)
        {
            WebImages images = new WebImages();
            
            images = _db.WebImages.SingleOrDefault(m=> m.Id == id);
            if (images == null)
            {
                images = new WebImages();
                return View(images);
            }

            return View(images);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpSert(int id, WebImages images)
        {
            if (ModelState.IsValid)
            {
                var files = HttpContext.Request.Form.Files;
                if(files.Count > 0)
                {
                    byte[] p1 = null;
                    using (var fs1 = files[0].OpenReadStream())
                    {
                        using (var ms1 = new MemoryStream())
                        {
                            fs1.CopyTo(ms1);
                            p1 = ms1.ToArray();
                        }
                    }
                    images.Picture = p1;
                }

                if (images.Id == 0)
                {
                    _db.WebImages.Add(images);
                }
                else
                {
                    var imageFromDb = _db.WebImages.FirstOrDefault(c => c.Id == id);

                    imageFromDb.Name = images.Name;
                    if(files.Count > 0)
                    {
                        imageFromDb.Picture = images.Picture;
                    }
                }
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return View(images);
        }

        #region API Calls
        [HttpGet]
        public IActionResult GetAll()
        {
            return Json(new { data = _db.WebImages.ToList() });
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var objFromDB = _db.WebImages.Find(id);
            if (objFromDB == null)
            {
                return Json(new { success = false, message = "Error while was deleting" });
            }

            _db.WebImages.Remove(objFromDB);
            _db.SaveChanges();
            return Json(new { success = true, message = "Deleted Successful" });
        }
        #endregion
    }
}
