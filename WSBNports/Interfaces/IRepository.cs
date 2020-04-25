using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WSBNports.Models;

namespace WSBNports.Interfaces
{
    public interface IRepository<T> where T : Entity
    {
        Task<T> GetByIdAsync(string id);
        Task<T> AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
    }
}
