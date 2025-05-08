using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IPostulationRepository : IBaseRepository<Postulation>
    {
        Task<Postulation?> GetByIdAsync(int id);
        Task<IEnumerable<Postulation>> GetByUserIdAsync(int userId);
        Task<IEnumerable<Postulation>> GetByJobIdAsync(int jobId);
        
    }
}
