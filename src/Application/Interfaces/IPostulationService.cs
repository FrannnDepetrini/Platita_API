using Application.Models.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IPostulationService
    {
        Task<PostulationDetailDTO> PostulateAsync(int userId, int jobId, float budget);
        Task UnpostulateAsync(int userId, int jobId);
        Task<PostulationDetailDTO?> GetByIdForPublisherAsync(int id);
        Task<MyPostulationDTO?> GetByIdForApplicantAsync(int id);
        Task<IEnumerable<PostulationDetailDTO>> GetMyPostulationsAsync(int userId);
        Task<IEnumerable<PostulationDetailDTO>> GetPostulationsByJobIdAsync(int jobId, int publisherId);
        Task AcceptPostulationAsync(int postulationId);
        Task RejectPostulationAsync(int postulationId);
    }
}
