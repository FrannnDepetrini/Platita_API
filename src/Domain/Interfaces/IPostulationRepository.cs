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
        Task<Postulation?> GetByIdForPublisherAsync(int id);
        Task<Postulation?> GetByIdForApplicantAsync(int id);
        Task<IEnumerable<Postulation>> GetByUserIdAsync(int userId);
        Task<IEnumerable<Postulation>> GetByJobIdAsync(int jobId);

        Task<Postulation> GetPostulationByJobAndPostulantId(int jobId, int postulantId);

        Task<bool> CheckDuplicatePostulation(int clientId, int jobId);
        Task SaveChangesAsync();
        Task<IEnumerable<Postulation>> GetAllMyPostulations(int userId);

    }
}
