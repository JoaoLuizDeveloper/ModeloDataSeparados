using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProjetoTempus.AccessData.Data.Repository.IRepository;
using ProjetoTempus.Extensions;
using ProjetoTempus.Models;
using ProjetoTempus.Utility;

namespace ProjetoTempus.Controllers
{
    [Area("Customer")]
    public class HomeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        //private HomeVM HomeVM;

        public HomeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            //HomeVM = new HomeVM()
            //{
            //    CategoryList = _unitOfWork.Category.GetAll(),
            //    ServiceList = _unitOfWork.Service.GetAll(includeProperties:"Frequency")
            //};

            return View();
        }

        public IActionResult Details(int id)
        {
            //var serviceFromDb = _unitOfWork.Cliente.GetFirstOrDefault(filter: c => c.Id == id);
            return View();
        }

        //public IActionResult AddToCart(int serviceId)
        //{
        //    List<int> sessionList = new List<int>();
        //    if(string.IsNullOrEmpty(HttpContext.Session.GetString(SD.SessionCart)))
        //    {
        //        sessionList.Add(serviceId);
        //        HttpContext.Session.Setobject(SD.SessionCart, sessionList);
        //    }
        //    else
        //    {
        //        sessionList = HttpContext.Session.Getobject<List<int>>(SD.SessionCart);
        //        if(sessionList!= null && !sessionList.Contains(serviceId))
        //        {
        //            sessionList.Add(serviceId);
        //            HttpContext.Session.Setobject(SD.SessionCart, sessionList);
        //        }
        //    }

        //    return RedirectToAction(nameof(Index));
        //}

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
