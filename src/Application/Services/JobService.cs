using Application.Interfaces;
using Application.Models;
using Application.Models.Requests;
using Application.Models.Responses;
using Domain.Constants;
using Domain.Entities;
using Domain.Interfaces;
using System.Collections.Generic;
using System.Security.Claims;

namespace Application.Services
{
    public class JobService : IJobService

    {
        private readonly IPostulationService _postulationService;
        private readonly IJobRepository _jobRepository;
        private readonly IUserRepository _userRepository;
        private readonly IClientRepository _clientRepository;
        public JobService(IPostulationService postulationService, IJobRepository jobRepository, IUserRepository userRepository, IClientRepository clientRepository)
        {
            _jobRepository = jobRepository;
            _userRepository = userRepository;
            _clientRepository = clientRepository;
            _postulationService = postulationService;
        }

                                    // GET
        public async Task<List<JobDTO>> GetJobsByClientLocationAsync(int userId)
        {
            var existingUser = await _clientRepository.GetById(userId);
            if (existingUser == null)
            {
                throw new Exception("Usuario no encontrado.");
            }
            var jobs = await _jobRepository.GetJobsByLocationAsync(existingUser.Province, existingUser.City, userId);

            var jobDtos = jobs.Select(j => new JobDTO
            {

                Id = j.Id,
                UserName = j.Client.UserName,
                Title = j.Title,
                AmountPostulations = j.AmountPostulations,
                AveragePrice = j.AveragePrice,
                Status = j.Status.ToString(),
                Province = j.Province,
                City = j.City,
                Description = j.Description,
                DayPublicationStart = j.DayPublicationStart,
                DayPublicationEnd = j.DayPublicationEnd,
                Category = j.Category.ToString(),
            }).ToList();
            return jobDtos;

        }
        
        public async Task<List<JobDTO>> GetJobsBySearchLocationAsync(string Province, string city, int userId)
        {
            var jobs = await _jobRepository.GetJobsByLocationAsync(Province, city, userId);
            var jobDtos = jobs.Select(j => new JobDTO
            {
                Id = j.Id,
                UserName = j.Client.UserName,
                Title = j.Title,
                AmountPostulations = j.AmountPostulations,
                AveragePrice = j.AveragePrice,
                Status = j.Status.ToString(),
                Province = j.Province,
                City = j.City,
                Description = j.Description,
                DayPublicationStart = j.DayPublicationStart,
                DayPublicationEnd = j.DayPublicationEnd,
                Category = j.Category.ToString()
            }).ToList();

            return jobDtos;
        }
        
        public async Task<IEnumerable<JobDTO>> GetJobsByCategory(JobFilteredByCategoryRequest request, int userId)
        {
            var jobs = (await _jobRepository.GetJobsByCategory(request.Category, userId)).ToList();

            var jobDtos = jobs.Select(j => new JobDTO
            {
                Id = j.Id,
                UserName = j.Client.UserName,
                Title = j.Title,
                AmountPostulations = j.AmountPostulations,
                AveragePrice = j.AveragePrice,
                Status = j.Status.ToString(),
                Province = j.Province,
                City = j.City,
                Description = j.Description,
                DayPublicationStart = j.DayPublicationStart,
                DayPublicationEnd = j.DayPublicationEnd,
                Category = j.Category.ToString()
            }).ToList();
            return jobDtos;
        }
        // Mis trabajos
        public async Task<List<JobDTO>> GetJobsByClientAsync(int userId)
        {
            var client = await _clientRepository.GetById(userId);
            if (client == null)
            {
                throw new Exception("Cliente no encontrado");
            }
            var jobs = await _jobRepository.GetByClientId(userId);
            var jobDtos = jobs.Select(j => new JobDTO
            {
                Id = j.Id,
                UserName = j.Client.UserName,
                Title = j.Title,
                AmountPostulations = j.AmountPostulations,
                AveragePrice = j.AveragePrice,
                Status = j.Status.ToString(),
                Province = j.Province,
                City = j.City,
                Description = j.Description,
                DayPublicationStart = j.DayPublicationStart,
                DayPublicationEnd = j.DayPublicationEnd,
                Category = j.Category.ToString()
            }).ToList();
            return jobDtos;
        }

        public async Task<List<AllJobsDTO>> GetAllJobs()
        {
            var jobs = await _jobRepository.GetAllJobs();

            return jobs.Select(AllJobsDTO.Create).ToList();
        }

        public async Task<List<JobDtoReport>> GetAllJobsReported()
        {
            var jobs = await _jobRepository.GetAllJobsReported();

            return jobs.Select(JobDtoReport.Create).ToList();
        }

        // POST
        public async Task<JobDTO> Create(JobRequest request, int userId)
        {
            if (!Enum.TryParse<CategoryEnum>(request.Category, ignoreCase: true, out var parsedCategory) ||
            !Enum.IsDefined(typeof(CategoryEnum), parsedCategory))
            {
                throw new ArgumentException($"Invalid category value: {request.Category}");
            }

            var newJob = new Job()
            {
                ClientId = userId,
                Title = request.Title,
                Status = JobStatusEnum.Available,
                Description = request.Description,
                Category = parsedCategory,
                DayPublicationEnd = request.DayPublicationEnd,
                Province = request.Province,
                City = request.City,

            };
            await _jobRepository.Create(newJob);

            var job = await _jobRepository.GetById(newJob.Id);

            var jobDTO = JobDTO.Create(job);

            return jobDTO;
        }

                                // UPDATE
        public async Task<JobDTO> Update(JobUpdateRequest request, int id, int userId)
        {
            var job = await _jobRepository.GetById(id);
            if (job == null)
            {
                throw new Exception("Job not found");
            }

            if (job.Client.Id != userId)
            {
                throw new UnauthorizedAccessException("You dont have permission");
            }

            if (job.Status == JobStatusEnum.Taken)
            {
                throw new Exception("You cant modify a job that has been taken");
            }

            if (!Enum.TryParse<CategoryEnum>(request.Category, ignoreCase: true, out var parsedCategory) ||
          !Enum.IsDefined(typeof(CategoryEnum), parsedCategory))
            {
                throw new ArgumentException($"Invalid category value: {request.Category}");
            }

            job.Title = request.Title;
            job.DayPublicationStart = job.DayPublicationStart;
            job.DayPublicationEnd = request.DayPublicationEnd;
            job.Province = request.Province;
            job.City = request.City;
            job.Description = request.Description;
            job.Category = parsedCategory;


            var updatedJob = await _jobRepository.Update(job);

            var jobDTO = JobDTO.Create(updatedJob);

            return jobDTO;

        }

        public async Task JobFinished(int idJob, int userId)
        {
            var job = await _jobRepository.GetById(idJob);
            if (job == null)
            {
                throw new Exception("Job not found");
            }
            if (job.Client.Id != userId)
            {
                throw new UnauthorizedAccessException("You dont have permission");
            }
            //var postulation = await _postulationService.GetPostulationsByJobIdAsync(job.Id, userId);
            //if (postulation == null)
            //{
            //    throw new Exception("You dont have postulations");
            //}
            var postulations = job.Postulations.ToList();
            if (postulations.Count() <= 0) throw new Exception("You dont have postulations");

            foreach (var post in postulations)
            {
                if (post.Status == PostulationStatusEnum.Success)
                {
                    post.Status = PostulationStatusEnum.Done;
                }
                if (post.Status == PostulationStatusEnum.Rejected)
                {
                    await _postulationService.DeletePostulationFisica(post);
                }
            }

            job.Status = JobStatusEnum.Done;

            await _jobRepository.Update(job);

        }

                                // DELETE
        //baja fisica
        public async Task Delete(int id, int userId)
        {
            var job = await _jobRepository.GetById(id);

            if (job == null)
            {
                throw new Exception("Job not found");
            }

            if (job.Client.Id != userId)
            {
                throw new UnauthorizedAccessException("You dont have permission");
            }

            if (job.Status == JobStatusEnum.Taken || job.Status == JobStatusEnum.Done)
            {
                throw new Exception("You cant delete a job taken or done.");
            }

            await _jobRepository.Delete(job);
        }

                                // PATCH
        //baja logica
        public async Task DeleteLogic(int id, int userId)
        {
            var job = await _jobRepository.GetById(id);

            if (job == null)
            {
                throw new Exception("Job not found");
            }

            if (job.Client.Id != userId)
            {
                throw new UnauthorizedAccessException("You dont have permission");
            }

            job.Status = JobStatusEnum.Deleted;

            await _jobRepository.Update(job);
        }



        public async Task ResetJobCancellation(int idJob, int userId)
        {
            var job = await _jobRepository.GetById(idJob);
            if (job == null)
            {
                throw new Exception("Job not found");
            }
            if (job.Client.Id != userId)
            {
                throw new UnauthorizedAccessException("You dont have permission");
            }

            var postulations = job.Postulations.ToList();
            if (postulations.Count() <= 0) throw new Exception("You dont have postulations");
            foreach (var post in postulations)
            {
                await _postulationService.DeletePostulationFisica(post);
            }

            job.DayPublicationStart = DateTime.Now;
            job.Status = JobStatusEnum.Available;

            await _jobRepository.Update(job);
        }
    }
}