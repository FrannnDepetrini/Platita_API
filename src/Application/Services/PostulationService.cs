using Application.Interfaces;
using Application.Models.Responses;
using Domain.Constants;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class PostulationService(IPostulationRepository postulationRepository, IJobRepository jobRepository) : IPostulationService
    {
        private readonly IPostulationRepository _postulationRepository = postulationRepository;
        private readonly IJobRepository _jobRepository = jobRepository;

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

        public async Task<IEnumerable<PostulationDetailDTO>> GetPostulationsByJobIdAsync(int jobId, int publisherId)
        {
            var postulation = await _postulationRepository.GetByJobIdAsync(jobId);
            
            if (postulation is null)
            {
                throw new Exception("Postulation not found");
            }

            var firstPostulation = postulation.FirstOrDefault();

            if (firstPostulation == null)
            {
                throw new Exception("No hay postulaciones para este trabajo");
            }

            var job = firstPostulation.Job;

            if (job.ClientId != publisherId)
            {
                throw new UnauthorizedAccessException("No estas autorizado para ver las publicaciones");
            }

            return postulation.Select(PostulationDetailDTO.Create);

        }

        public async Task<PostulationDetailDTO> PostulateAsync(int userId, int jobId, float budget)
        {
            var job = await _jobRepository.GetById(jobId);
            if (job == null)
            {
                throw new Exception("Trabajo no encontrado");
            }

            if(job.ClientId == userId)
            {
                throw new Exception("No puede postular a su propio trabajo");
            }

            var postulation = new Postulation
            {
                JobId = jobId,
                ClientId = userId,
                Budget = budget,
                Status = PostulationStatusEnum.Pending
            };

            await _postulationRepository.Create(postulation);

            return PostulationDetailDTO.Create(postulation);
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
