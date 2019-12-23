using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models.Repositories.Abstractions;

namespace WebApplication1.Models.Repositories.Implementations
{
    public class EFProfessionistRepository : EFCrudRepository<Professionist> , ProfessionistRepository
    {

        public EFProfessionistRepository(NoNullProjectContext ctx) :base(ctx)
        {        }

  

        //public async Task<List<Professionist>> AllAsync()
        //{
        //    return await ctx.Professionists
        //        .Include(p => p.Skills)
        //        .Include(p => p.Availabilities)
        //        .ToListAsync();
        //}


    }
}
