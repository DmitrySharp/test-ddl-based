using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestOrder.Models.Entities;

namespace TestOrder.DL.Interfaces
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        Task<IEnumerable<TEntity>> GetAllAsync();
        IQueryable<TEntity> GetBaseQuery();
    }
}