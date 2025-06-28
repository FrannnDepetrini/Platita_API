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
        private readonly IEmailService _emailService;
        private readonly IJobRepository _jobRepository;
        private readonly IUserRepository _userRepository;
        private readonly IClientRepository _clientRepository;

        public JobService(
            IPostulationService postulationService,
            IEmailService emailService,
            IJobRepository jobRepository,
            IUserRepository userRepository,
            IClientRepository clientRepository
            )
        {
            _jobRepository = jobRepository;
            _userRepository = userRepository;
            _clientRepository = clientRepository;
            _postulationService = postulationService;
            _emailService = emailService;
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

        public async Task<JobDTO> GetJobById(int jobId)
        {
            var job = await _jobRepository.GetById(jobId);


            return JobDTO.Create(job);

        }

        public async Task<AllJobsDTO> GetJobForModeratorById(int jobId)
        {
            var job = await _jobRepository.GetById(jobId);


            return AllJobsDTO.Create(job);
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
                Province = request.Province,
                City = request.City,

            };

            if (!string.IsNullOrWhiteSpace(request.DayPublicationEnd))
            {
                newJob.DayPublicationEnd = DateOnly.Parse(request.DayPublicationEnd);
            }

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

            if (!string.IsNullOrWhiteSpace(request.Category))
            {
                if (!Enum.TryParse<CategoryEnum>(request.Category, ignoreCase: true, out var parsedCategory) ||
                    !Enum.IsDefined(typeof(CategoryEnum), parsedCategory))
                {
                    throw new ArgumentException($"Invalid category value: {request.Category}");
                }

                job.Category = parsedCategory;
            }

            DateOnly? parsedDate = string.IsNullOrWhiteSpace(request.DayPublicationEnd)
            ? null
            : DateOnly.Parse(request.DayPublicationEnd);

            job.Title = request.Title ?? job.Title;
            job.DayPublicationStart = job.DayPublicationStart;
            job.DayPublicationEnd = parsedDate ?? job.DayPublicationEnd;
            job.Province = request.Province ?? job.Province;
            job.City = request.City ?? job.City;
            job.Description = request.Description ?? job.Description;


            var updatedJob = await _jobRepository.Update(job);

            var jobDTO = JobDTO.Create(updatedJob);

            return jobDTO;

        }

        public async Task JobFinished(int idJob, int userId)
        {
            var job = await _jobRepository.GetById(idJob);
            if (job.PostulationSelectedId == null)
            {
                throw new Exception("Job has no applicants");
            }
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

            job.DateJobFinished = DateOnly.FromDateTime(DateTime.Today);

            await _emailService.SendNotificationEmailAsync(job.Client.Email, job.Client.UserName, CategoryNotificationsEnum.JobFinished);

            await _emailService.SendNotificationEmailAsync(job.PostulationSelected.Client.Email, job.PostulationSelected.Client.UserName, CategoryNotificationsEnum.JobFinished);

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

            if (postulations.Count() > 0)
            {

                foreach (var post in postulations)
                {
                    await _postulationService.DeletePostulationFisica(post);
                }

            }

            job.DayPublicationStart = DateOnly.FromDateTime(DateTime.Today);
            job.Status = JobStatusEnum.Available;
            job.DayPublicationEnd = job.DayPublicationStart.Value.AddDays(14);
            await _jobRepository.Update(job);
        }


    }
}