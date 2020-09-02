using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using ProjetoTempus.AccessData.Data.Repository.IRepository;
using ProjetoTempus.Models.ViewModels;

namespace ProjetoTempus.Areas.Admin.Controllers
{
    [Authorize]
    [Area("Admin")]
    public class ServiceController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _hostEnvironment;
        [BindProperty]
        public ServiceVM ServVM { get; set; }

        public ServiceController(IUnitOfWork unitOfWork, IWebHostEnvironment hostEnvironment)
        {
            _unitOfWork = unitOfWork;
            _hostEnvironment = hostEnvironment;
        }

        public IActionResult Upsert(int? id)
        {
            ServVM = new ServiceVM()
            {
                Service = new Models.Service(),
                CategoryList = _unitOfWork.Category.GetCategoryListForDropDown(),
                FrequencyList  = _unitOfWork.Frequency.GetFrequencyListForDropDown()
            };
            if (id == null)
            {
                return View(ServVM);
            }

            ServVM.Service = _unitOfWork.Service.Get(id.GetValueOrDefault());
            if (ServVM == null)
            {
                return NotFound();
            }

            return View(ServVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpSert(ServiceVM serviceVM)
        {
            if (ModelState.IsValid)
            {
                string webRootPath = _hostEnvironment.WebRootPath;
                var files = HttpContext.Request.Form.Files;
                if(ServVM.Service.Id == 0)
                {
                    //New Service
                    #region Upload Image
                    string fileName = Guid.NewGuid().ToString();
                    var uploads = Path.Combine(webRootPath, @"images\services\");
                    var extension = Path.GetExtension(files[0].FileName);

                    using (var fileStreams = new FileStream(Path.Combine(uploads, fileName + extension), FileMode.Create))
                    {
                        files[0].CopyTo(fileStreams);
                    }

                    ServVM.Service.Image = @"\images\services\" + fileName + extension;

                    #endregion
                    _unitOfWork.Service.Add(ServVM.Service);
                }
                else
                {
                    //Edit Service

                    var serviceFromDb = _unitOfWork.Service.Get(ServVM.Service.Id);
                    if( files.Count > 0)
                    {
                        string fileName = Guid.NewGuid().ToString();
                        var uploads = Path.Combine(webRootPath, @"images\services\");
                        var extension_new = Path.GetExtension(files[0].FileName);

                        var imagePath = Path.Combine(webRootPath, serviceFromDb.Image.TrimStart('\\'));
                        if(System.IO.File.Exists(imagePath))
                        {
                            System.IO.File.Delete(imagePath);
                        }

                        using (var fileStreams = new FileStream(Path.Combine(uploads, fileName + extension_new), FileMode.Create))
                        {
                            files[0].CopyTo(fileStreams);
                        }
                        ServVM.Service.Image = @"\images\services\" + fileName + extension_new;
                    }
                    else
                    {
                        ServVM.Service.Image = serviceFromDb.Image;
                    }

                    _unitOfWork.Service.Update(ServVM.Service);
                }
                _unitOfWork.Save();
                return RedirectToAction(nameof(Index));
            }

            ServVM.CategoryList = _unitOfWork.Category.GetCategoryListForDropDown();
            ServVM.FrequencyList = _unitOfWork.Frequency.GetFrequencyListForDropDown();
            return View(ServVM);
        }

        public IActionResult Index()
        {
            return View();
        }

        #region API Calls
        public IActionResult GetAll()
        {
            return Json(new { data = _unitOfWork.Service.GetAll(includeProperties:"Category,Frequency")});
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var objFromDB = _unitOfWork.Service.Get(id);
            string webRootPath = _hostEnvironment.WebRootPath;
            var imagePath = Path.Combine(webRootPath, objFromDB.Image.TrimStart('\\'));
            if(System.IO.File.Exists(imagePath))
            {
                System.IO.File.Delete(imagePath);
            }
            
            if (objFromDB == null)
            {
                return Json(new { success = false, message = "Error while was deleting" });
            }

            _unitOfWork.Service.Remove(objFromDB);
            _unitOfWork.Save();
            return Json(new { success = true, message = "Deleted Successful" });
        }
        #endregion
    }
}
