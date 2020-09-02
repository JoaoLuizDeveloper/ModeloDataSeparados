using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProjetoTempus.AccessData.Data.Repository.IRepository;
using ProjetoTempus.DataAccess.Data;
using ProjetoTempus.Models;

namespace ProjetoTempus.AccessData.Data.Repository
{
    public class ClienteRepository : Repository<Cliente> , IClienteRepository
    {
        private readonly ApplicationDbContext _db;

        public ClienteRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;

        }

        public IEnumerable<SelectListItem> GetClienteListForDropDown()
        {
            return _db.Cliente.Select(i => new SelectListItem()
            {
                Text = i.Nome,
                Value = i.Id.ToString()
            });
        }

        public void Update(Cliente cliente)
        {
            var obj = _db.Cliente.FirstOrDefault(j => j.Id == cliente.Id);

            obj.Nome = cliente.Nome;
            obj.CPF = cliente.CPF;
            obj.DataNacimento = cliente.DataNacimento;
            obj.DataCadastro = cliente.DataCadastro;
            obj.RendaFamiliar = cliente.RendaFamiliar;

            _db.SaveChanges();
        }
    }
}
