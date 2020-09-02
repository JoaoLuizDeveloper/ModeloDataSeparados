using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;
using ProjetoTempus.Models;

namespace ProjetoTempus.AccessData.Data.Repository.IRepository
{
    public interface IServiceRepository : IRepository<Service>
    {
        //IEnumerable<SelectListItem> GetCategoryListForDropDown();

        void Update(Service service);
    }
}
