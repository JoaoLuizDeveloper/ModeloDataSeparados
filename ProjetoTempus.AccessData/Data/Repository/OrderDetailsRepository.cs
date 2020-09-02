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
    public class OrderDetailsRepository : Repository<OrderDetails> , IOrderDetailsRepository
    {
        private readonly ApplicationDbContext _db;

        public OrderDetailsRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;

        }

    }
}
