using Microsoft.EntityFrameworkCore;
using mska_data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mska_data.Repositories
{
    public class BaseRepository<T> : IRepository<T> where T : class
    {
        protected readonly MskacenterDbContext _context;
        protected readonly DbSet<T> _dbSet;

        public BaseRepository(MskacenterDbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public IEnumerable<T> GetAll()
            => _dbSet.ToList();

        public T? GetById(int id)
            => _dbSet.Find(id);

        public void Add(T entity)
            => _dbSet.Add(entity);

        public void Update(T entity)
            => _dbSet.Update(entity);

        public void Delete(T entity)
            => _dbSet.Remove(entity);
    }
}
