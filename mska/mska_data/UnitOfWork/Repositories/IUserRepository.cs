using Microsoft.EntityFrameworkCore;
using mska_data.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mska_data.Repositories
{
    public interface IUserRepository : IRepository<User>
    {
        User GetByUsername(string username);
    }
}
