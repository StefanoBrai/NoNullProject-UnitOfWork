using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models.Repositories.Abstractions;

namespace WebApplication1.Models.Repositories.Implementations
{
    public class EFCrudRepository<T> : CrudRepository<T> where T : class
    {
        protected NoNullProjectContext ctx;

        public EFCrudRepository(NoNullProjectContext ctx)
        {
            this.ctx = ctx;
        }

        public Task<bool> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> FindAll()
        {
            return ctx.Set<T>();       
        }

        public async Task<T> FindByIdAsync(int id)
        {
            return await ctx.Set<T>().FindAsync(id);
        }

        public T Insert(T toInsert)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(int id, T toUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
