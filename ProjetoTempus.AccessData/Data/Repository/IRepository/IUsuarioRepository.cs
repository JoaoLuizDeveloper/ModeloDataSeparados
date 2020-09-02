using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;
using ProjetoTempus.Models;

namespace ProjetoTempus.AccessData.Data.Repository.IRepository
{
    public interface IUsuarioRepository : IRepository<Usuario>
    {
        void LockUser(string userId);
        void UnLockUser(string userId);
    }
}
