using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models.Repositories.Abstractions;

namespace WebApplication1.Models.UnitOfWork.Implementations
{
    public class EFCollaborationUnitOfWork : CollaborationUnitOfWork
    {
        public ProfessionistRepository Professionist { get; set; }
        public RequestRepository Request { get; set; }
        private NoNullProjectContext ctx;
        public EFCollaborationUnitOfWork(NoNullProjectContext ctx, ProfessionistRepository professionist, RequestRepository request)
        {
            Professionist = professionist;
            Request = request;
            this.ctx = ctx;

        }
        public async Task<IEnumerable<Professionist>> FindAllProfessionistsAsync()
        {
            return await Professionist.FindAll().AsQueryable()
                .Include(p => p.Destination).ToListAsync();
        }

        public async Task<IEnumerable<Request>> FindAllRequestAsync()
        {
            return await Request.FindAll().AsQueryable()
                .Include(r => r.Comp)
                .Include(r => r.Destination)
                .Include(r => r.Proj)
                .Include(r => r.Skill).ToListAsync();
        }
    }
}
