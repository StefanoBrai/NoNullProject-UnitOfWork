using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models.Repositories.Abstractions;

namespace WebApplication1.Models.UnitOfWork
{
    public interface CollaborationUnitOfWork
    {
        ProfessionistRepository Professionist { get; set; }
        RequestRepository Request { get; set;  }
        Task<IEnumerable<Professionist>> FindAllProfessionistsAsync();
        Task<IEnumerable<Request>> FindAllRequestAsync();
        //void Begin();
        //void End();
        //void Save();
        //void Cancel();  //Prende in input qualcosa
    }
}
