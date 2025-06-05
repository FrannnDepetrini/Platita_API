using Application.Models.Responses;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IPostulationService
    {
        Task<PostulationDetailDTO> PostulateAsync(int userId, int jobId, float budget, DateTime jobDay);
        Task<IEnumerable<PostulationDetailDTO>> GetPostulationsByJobIdAsync(int jobId, int publisherId);
        Task<bool> DeletePostulationFisica(Postulation postJob);
        Task<bool> DeletePostulationPhysics (int postulantId, int jobId);
        Task<bool> DeletePostulationLogic(int postulantId, int jobId);
        Task<PostulationDTO> ChangeStatusPostulation(int jobId, int postulantId, int userId);
        Task<IEnumerable<MyPostulationDTO>> GetMyPostulations(int userId);
        Task CancelPostulation(int jobId, int postulationId, int userId);
        Task<string> ShowPhoneForAcceptedPostulation(int postulationId, int userId);
    }
}
