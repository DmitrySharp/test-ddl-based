using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestOrder.Models.Entities;

namespace TestOrder.DL.Interfaces
{
    public interface IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        Task<TEntity> GetAsync(int id);
        Task<IEnumerable<TEntity>> GetAllAsync();
        IQueryable<TEntity> GetBaseQuery();
        Task<TEntity> GetNoTrackingAsync(int id);
    }
}