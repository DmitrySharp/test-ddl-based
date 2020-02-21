using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using TestOrder.DL.Interfaces;
using TestOrder.Models.Entities;

namespace TestOrder.DL.Services
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        private readonly ApplicationDbContext _context;

        public BaseRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<TEntity> GetAsync(int id)
        {
            return await _context.Set<TEntity>().FindAsync(id);
        }

        public IQueryable<TEntity> GetBaseQuery()
        {
            return _context.Set<TEntity>().AsNoTracking().AsQueryable();
        }

        public async Task<TEntity> GetNoTrackingAsync(int id)
        {
            return await _context.Set<TEntity>().AsNoTracking().FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _context.Set<TEntity>().AsNoTracking().ToListAsync();
        }


    }
}