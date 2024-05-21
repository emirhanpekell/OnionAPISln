using OnionAPI.Application.Interfaces.Repositories;
using OnionAPI.Application.Interfaces.UnitofWorks;
using OnionAPI.Persistence.Context;
using OnionAPI.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionAPI.Persistence.UnitOfWorks
{
    public class UnitofWork : IUnitofWork
    {
        private readonly AppDbContext dbContext;

        public UnitofWork(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async ValueTask DisposeAsync() => await dbContext.DisposeAsync();

        public int Save() => dbContext.SaveChanges();
        

        public Task<int> SaveAsync()=>dbContext.SaveChangesAsync();
        

        IReadRepository<T> IUnitofWork.GetReadRepository<T>()=>new ReadRepository<T>(dbContext);
        

        IWriteRepository<T> IUnitofWork.GetWriteRepository<T>() => new WriteRepository<T>(dbContext);

    }
}
