using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WSBNports.Models;

namespace WSBNports.Infrastructure
{
    public class NportRepository : INportRepository
    {
        public Task<Nport> AddAsync(Nport entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Nport entity)
        {
            throw new NotImplementedException();
        }

        public Task<Nport> GetByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Nport entity)
        {
            throw new NotImplementedException();
        }
    }
}
