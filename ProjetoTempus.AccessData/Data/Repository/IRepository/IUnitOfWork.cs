using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoTempus.AccessData.Data.Repository.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        IUsuarioRepository Usuario { get; }
        IClienteRepository Cliente { get; }

        void Save();
    }
}
