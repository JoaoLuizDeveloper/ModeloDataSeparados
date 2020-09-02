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
    public class ServiceRepository : Repository<Service> , IServiceRepository
    {
        private readonly ApplicationDbContext _db;

        public ServiceRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;

        }

        //public IEnumerable<SelectListItem> GetCategoryListForDropDown()
        //{
        //    return _db.Service.Select(i => new SelectListItem()
        //    {
        //        Text = i.Name,
        //        Value = i.Id.ToString()
        //    });
        //}

        public void Update(Service service)
        {
            var obj = _db.Service.FirstOrDefault(j => j.Id == service.Id);

            obj.Name = service.Name;
            obj.Description = service.Description;
            obj.Price = service.Price;
            obj.Image = service.Image;
            obj.CategoryId = service.CategoryId;
            obj.FrequencyId = service.FrequencyId;

            _db.SaveChanges();
        }
    }
}
