using Microsoft.EntityFrameworkCore;
using mska_data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mska_data.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(MskacenterDbContext context) : base(context)
        {
        }

        public User? GetByUsername(string username)
        {
            return _dbSet.FirstOrDefault(x => x.Username == username);
        }
    }
}
