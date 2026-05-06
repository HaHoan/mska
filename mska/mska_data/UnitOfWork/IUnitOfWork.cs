using mska_data.Models;
using mska_data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mska_data.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IUserRepository Users { get; }
        ICourseRepository Course { get; }

        int SaveChanges();

        void BeginTransaction();
        void Commit();
        void Rollback();
    }
}
