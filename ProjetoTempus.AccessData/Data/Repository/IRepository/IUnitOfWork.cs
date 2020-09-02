using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoTempus.AccessData.Data.Repository.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        ICategoryRepository Category { get; }
        IFrequencyRepository Frequency { get; }
        IServiceRepository Service { get; }
        IOrderHeaderRepository OrderHeader { get; }
        IOrderDetailsRepository OrderDetails { get; }
        IUsuarioRepository Usuario { get; }
        IUSP_Call USP_Call { get; }

        void Save();
    }
}
