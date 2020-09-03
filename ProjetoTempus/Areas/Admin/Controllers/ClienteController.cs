using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProjetoTempus.AccessData.Data.Repository.IRepository;
using ProjetoTempus.Models;
using ProjetoTempus.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

        public IActionResult Create()
        {
            Cliente cliente = new Cliente();
            
            return View(cliente);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Cliente cliente)
        {
            if(cliente.RendaFamiliar == null || cliente.RendaFamiliar < 0)
            {
                cliente.RendaFamiliar = 0;
            }

            if(cliente.DataNascimento > DateTime.Now)
            {
                ViewBag.Data = DateTime.Now.Date;
                return View(cliente);
            }

            if (ModelState.IsValid)
            {
                cliente.DataCadastro = DateTime.Now;
                _unitOfWork.Cliente.Add(cliente);
                
                _unitOfWork.Save();
                return RedirectToAction(nameof(Index));
            }

            return View(cliente);
        }

        public IActionResult Details(int id)
        {
            Cliente cliente = new Cliente();

            cliente = _unitOfWork.Cliente.Get(id);

            return View(cliente);
        }

        public IActionResult Edit(int id)
        {
            Cliente cliente = new Cliente();

            cliente = _unitOfWork.Cliente.Get(id);
            if (cliente == null)
            {
                return NotFound();
            }

            return View(cliente);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Cliente.Update(cliente);
             
                _unitOfWork.Save();
                return RedirectToAction(nameof(Index));
            }

            return View(cliente);
        }

        #region API Calls
        [HttpGet]
        public IActionResult GetAll()
        {
            return Json(new { data = _unitOfWork.Cliente.GetAll() });
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var objFromDB = _unitOfWork.Cliente.Get(id);
            if (objFromDB == null)
            {
                return Json(new { success = false, message = "Erro enquanto estava deletando" });
            }

            _unitOfWork.Cliente.Remove(objFromDB);
            _unitOfWork.Save();
            return Json(new { success = true, message = "Deletado com Sucesso" });
        }

        [HttpPost]
        public JsonResult SearchCpf(string id)
        {
            if(!string.IsNullOrEmpty(id))
            {
                var cli = _unitOfWork.Cliente.GetFirstOrDefault(x => x.CPF == id);

                if (cli != null && !string.IsNullOrEmpty(cli.CPF))
                {
                    return Json(new { success = false, message = "Cpf já cadastrado" });
                }
            }          
            
            return Json(new {success = true});
        }
        #endregion

        #region Relatorios
        [HttpGet]
        public IActionResult Relatorios()
        {
            var menos18 = DateTime.Now.Year - 18;
            var maioresde18 = _unitOfWork.Cliente.GetAll(filter: o=> o.DataNascimento.Year < menos18);
            var rendas = _unitOfWork.Cliente.GetAll();
            double totalRenda = 0.00;
            int totalPessoas = 0;
            
            foreach (var r in rendas)
            {
                //Vericar somente as pessoas que colocaram renda
                if(r.RendaFamiliar != null && r.RendaFamiliar > 0.00)
                {
                    totalRenda = totalRenda + r.RendaFamiliar.GetValueOrDefault();
                    totalPessoas += 1;
                }                
            }
            double media = totalRenda / totalPessoas;
            int final = 0;

            foreach(var m in maioresde18)
            {
                if(m.RendaFamiliar > media)
                final += 1;
            }

            ViewBag.Relatorio1 = final;

            var mo = new List<int>();
            int qtdC = 0;
            int qtdB = 0;
            int qtdA = 0;

            var clientesC = _unitOfWork.Cliente.GetAll(filter: x => x.RendaFamiliar <= 980);
            var clientesB = _unitOfWork.Cliente.GetAll(filter: x => x.RendaFamiliar > 980 && x.RendaFamiliar <= 2500);
            var clientesA = _unitOfWork.Cliente.GetAll(filter: x => x.RendaFamiliar > 2500);

            if (clientesA != null)
            {
                foreach (var a in clientesA)
                {
                    qtdA += 1;
                }
                mo.Add(qtdA);
            }

            if (clientesB != null)
            {
                foreach (var b in clientesB)
                {
                    qtdB += 1;
                }
                mo.Add(qtdB);
            }

            if (clientesC != null)
            {
                foreach (var c in clientesC)
                {
                    qtdC += 1;
                }
                mo.Add(qtdC);
            }

            ViewBag.Relatorio2 = mo;

            return View();
        }

        public IActionResult Dados(int filtro = 0)
        {
            var model = new List<Cliente>();

            if(filtro == 0)
            {
                var vm = _unitOfWork.Cliente.GetAll();
                foreach(var item in vm)
                {
                    model.Add(item);
                }
            }
            else if(filtro == 1)
            {
                var vm = _unitOfWork.Cliente.GetAll(filter: o => o.DataCadastro.Year == DateTime.Now.Year && o.DataCadastro.Month == DateTime.Now.Month && o.DataCadastro.Day == DateTime.Now.Day);
                foreach (var item in vm)
                {
                    model.Add(item);
                }
            }
            else if (filtro == 2)
            {
                DateTime[] last7Days = Enumerable.Range(0, 7).Select(i => DateTime.Now.Date.AddDays(-i)).ToArray();
                
                foreach(var day in last7Days)
                {
                    var vm = _unitOfWork.Cliente.GetAll(filter: o => o.DataCadastro.Date == day.Date);

                    foreach (var item in vm)
                    {
                        model.Add(item);
                    }
                }                
            }
            else if (filtro == 3)
            {

                var vm = _unitOfWork.Cliente.GetAll(filter: o => o.DataCadastro.Year == DateTime.Now.Year && o.DataCadastro.Month == DateTime.Now.Month);
                foreach (var item in vm)
                {
                    model.Add(item);
                }
            }

            ViewBag.Filtro = filtro;
            return View(model);
        }
        #endregion
    }
}
