using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IPostulationService
    {
        Task PostulateAsync(int userId, int jobId, float budget);
        Task UnpostulateAsync(int userId, int jobId);
        Task<PostulationResponseDTO?> GetByIdAsync(int id);
        Task<IEnumerable<PostulationResponseDTO>> GetMyPostulationsAsync(int userId);
        Task<IEnumerable<PostulationResponseDTO>> GetPostulationsByJobIdAsync(int jobId);
        Task AcceptPostulationAsync(int postulationId);
        Task RejectPostulationAsync(int postulationId);
    }
}
