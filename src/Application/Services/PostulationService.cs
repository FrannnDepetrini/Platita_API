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


       
        public async Task<IEnumerable<PostulationDetailDTO>> GetPostulationsByJobIdAsync(int jobId, int publisherId)
        {
            var postulation = await _postulationRepository.GetByJobIdAsync(jobId);

            if (postulation is null)
            {
                throw new Exception("Job not found");
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

            if (job.ClientId == userId)
            {
                throw new Exception("No puede postular a su propio trabajo");
            }

            var isDuplicatePostulation = await _postulationRepository.CheckDuplicatePostulation(userId, jobId);

            if (isDuplicatePostulation)
            {
                throw new Exception("Ya te postulaste a este trabajo");
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

        public async Task<PostulationDTO> ChangeStatusPostulation(int jobId, int postulantId, int userId)
        {
            var selectedPostulant = await _postulationRepository.GetPostulationByJobAndPostulantId(jobId, postulantId);

            if (selectedPostulant.Job.ClientId != userId)
            {
                throw new Exception("No autorizado");
            }



            if (selectedPostulant == null)
            {
                throw new Exception("Postulante no encontrado");
            }

            var allPostulations = await _postulationRepository.GetByJobIdAsync(jobId);

            foreach (var postulation in allPostulations)
            {
                if (postulation.Id == selectedPostulant.Id)
                {
                    postulation.Status = PostulationStatusEnum.Success;
                }
                else
                {
                    postulation.Status = PostulationStatusEnum.Rejected;
                }
            }
            selectedPostulant.Job.Status = JobStatusEnum.Taken;

            await _postulationRepository.SaveChangesAsync();

            return new PostulationDTO
            {
                Id = selectedPostulant.Id,
                UserName = selectedPostulant.Client.UserName,
                Email = selectedPostulant.Client.Email,
                Province = selectedPostulant.Client.Province,
                City = selectedPostulant.Client.City,
                Phone = selectedPostulant.Client.PhoneNumber,
                Status = selectedPostulant.Status.ToString()
            };

        }

        public async Task<bool> DeletePostulationFisic(int jobId, int postulationId)
        {
            var postJob = await _postulationRepository.GetPostulationByJobAndPostulantId(jobId, postulationId);

            if (postJob == null)
            {
                throw new Exception("Not found");
            }

            await _postulationRepository.Delete(postJob);
            await _postulationRepository.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeletePostulationLogic(int jobId, int postulationId)
        {
            var postJob = await _postulationRepository.GetPostulationByJobAndPostulantId(jobId, postulationId);

            if (postJob == null)
            {
                throw new Exception("Not found");
            }

            var allPostulations = await _postulationRepository.GetByJobIdAsync(jobId);

            foreach (var postulation in allPostulations)
            {
                if (postulation.Id == postJob.Id)
                {
                    postulation.Status = PostulationStatusEnum.Rejected;
                }

            }

            await _postulationRepository.SaveChangesAsync();
            return true;
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

        public async Task UnpostulateAsync(int userId, int jobId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<MyPostulationDTO>> GetMyPostulations(int userId)
        {
            var posts = await _postulationRepository.GetAllMyPostulations(userId);
            Console.WriteLine(posts.GetType());

            var result = posts.Select(p => new MyPostulationDTO
            {
                Id = p.Id,
                Budget = p.Budget,
                Status = p.Status.ToString(),
                Job = new JobDTO
                {
                    Id = p.Job.Id,
                    Title = p.Job.Title,
                    AveragePrice = p.Job.AveragePrice,
                    AmountPostulations = p.Job.AmountPostulations,
                    Status = p.Job.Status.ToString(),
                    Province = p.Job.Province,
                    City = p.Job.City,
                    DayPublicationStart = p.Job.DayPublicationStart,
                    DayPublicationEnd = p.Job.DayPublicationEnd,
                    Description = p.Job.Description,
                    Category = p.Job.Category.ToString()
                }
            }).ToList();

            return result;
        }

    }
}
