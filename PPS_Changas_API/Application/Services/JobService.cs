using Application.Interfaces;
using Application.Models;
using Application.Models.Requests;
using Application.Models.Responses;
using Domain.Constants;
using Domain.Entities;
using Domain.Interfaces;
using System.Security.Claims;

namespace Application.Services
{
    public class JobService : IJobService

    {
        private readonly IJobRepository _jobRepository;
        private readonly IUserRepository _userRepository;

        public JobService(IJobRepository jobRepository, IUserRepository userRepository)
        {
            _jobRepository = jobRepository;
            _userRepository = userRepository;
        }


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

            await _jobRepository.Delete(job);
        }

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
            job.DateTime = null;

            await _jobRepository.Update(job);
        }

        public async Task<JobDTO> Update(JobUpdateRequest request, int id, int userId)
        {
            var job = await _jobRepository.GetById(id);
            if (job == null)
            {
                throw new Exception("Job not found");
            }

            if(job.Client.Id != userId)
            {
                throw new UnauthorizedAccessException("You dont have permission");
            }

            if(job.Status == JobStatusEnum.Taken)
            {
                throw new Exception("You cant modify a job that has been taken");
            }

            if (!Enum.TryParse<CategoryEnum>(request.Category, ignoreCase: true, out var parsedCategory) ||
          !Enum.IsDefined(typeof(CategoryEnum), parsedCategory))
            {
                throw new ArgumentException($"Invalid category value: {request.Category}");
            }

            job.Title = request.Title;
            job.DateTime = request.DateTime;
            job.State = request.State;
            job.City = request.City;
            job.Description = request.Description;
            job.Category = parsedCategory;
            job.Picture = request.Picture;
           
            
            var updatedJob = await _jobRepository.Update(job);

            var jobDTO = JobDTO.Create(updatedJob);

            return jobDTO;

        }

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
                DateTime = request.DateTime,
                Picture = request.Picture,
                State = request.State,
                City = request.City
            };
            await _jobRepository.Create(newJob);

            var job = await _jobRepository.GetById(newJob.Id);

            var jobDTO = JobDTO.Create(job);

            return jobDTO;
        }

    }
}