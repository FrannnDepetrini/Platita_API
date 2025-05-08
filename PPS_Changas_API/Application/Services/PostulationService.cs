using Application.Interfaces;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class PostulationService(IPostulationRepository postulationRepository) : IPostulationService
    {
        private readonly IPostulationRepository _postulationRepository = postulationRepository;

        public Task AcceptPostulationAsync(int postulationId)
        {
            throw new NotImplementedException();
        }

        public Task<PostulationResponseDTO?> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<PostulationResponseDTO>> GetMyPostulationsAsync(int userId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<PostulationResponseDTO>> GetPostulationsByJobIdAsync(int jobId)
        {
            throw new NotImplementedException();
        }

        public Task PostulateAsync(int userId, int jobId, float budget)
        {
            throw new NotImplementedException();
        }

        public Task RejectPostulationAsync(int postulationId)
        {
            throw new NotImplementedException();
        }

        public Task UnpostulateAsync(int userId, int jobId)
        {
            throw new NotImplementedException();
        }
    }
}
