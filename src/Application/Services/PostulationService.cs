using Application.Interfaces;
using Application.Models.Responses;
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

        public async Task<PostulationDetailDTO?> GetByIdForPublisherAsync(int id)
        {
            var postulation = await _postulationRepository.GetByIdForPublisherAsync(id);
            if(postulation is null)
            {
                throw new Exception("Postulation not found");
            }

            var postulationDetailDTO = PostulationDetailDTO.Create(postulation);

            return postulationDetailDTO;
        }     
        
        public async Task<MyPostulationDTO?> GetByIdForApplicantAsync(int id)
        {
            var postulation = await _postulationRepository.GetByIdForApplicantAsync(id);
            if(postulation is null)
            {
                throw new Exception("Postulation not found");
            }

            var myPostulationDTO = MyPostulationDTO.Create(postulation);

            return myPostulationDTO;
        }

        public async Task<IEnumerable<PostulationDetailDTO>> GetMyPostulationsAsync(int userId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<PostulationDetailDTO>> GetPostulationsByJobIdAsync(int jobId)
        {
            throw new NotImplementedException();
        }

        public async Task PostulateAsync(int userId, int jobId, float budget)
        {
            throw new NotImplementedException();
        }

        public async Task RejectPostulationAsync(int postulationId)
        {
            throw new NotImplementedException();
        }

        public async Task UnpostulateAsync(int userId, int jobId)
        {
            throw new NotImplementedException();
        }
    }
}
