using Application.Interfaces;
using Application.Model;
using Application.Model.Requests;
using Domain.Entities;
using Domain.Interfaces;

namespace Application.Services
{
    public class JobService : IJobService

    {
        private readonly IJobRepository _jobRepository;

        public JobService(IJobRepository jobRepository)
        {
            _jobRepository = jobRepository;
        }
        //baja fisica
        public async Task Delete(int id)
        {
            var job = await _jobRepository.GetById(id);

            if (job == null)
            {
                throw new Exception("Job not found");
            }

            await _jobRepository.Delete(job);
        }

        //baja logica
        public async Task DeleteLogic(int id)
        {
            var job = await _jobRepository.GetById(id);

            if (job == null)
            {
                throw new Exception("Job not found");
            }

            job.Available = false;
            job.DateTime = null;

            await _jobRepository.Update(job);
        }

        public async Task<Job> Update(JobUpdateRequest request, int id)
        {
            var job = await _jobRepository.GetById(id);
            if (job == null)
            {
                throw new Exception("Job not found");
            }
            job.EmployerName = request.EmployerName;
            job.Title = request.Title;
            job.DateTime = request.DateTime;
            job.Location = request.Location;
            job.Description = request.Description;
            job.Category = request.Category;
            
            await _jobRepository.Update(job);

            return job;

        }

        public async Task<Job> Create(JobRequest request)
        {
            var newJob = new Job(request.EmployerName,request.Title, request.Location, request.Description, request.Category);
            await _jobRepository.Create(newJob);

            return newJob;
        }

        // public Job Create(JobRequest request)
        // {
        //     var newJob = new Job{
        //         Title = request.Title,
        //         Price = request.Price,
        //         DateTime = request.DateTime,
        //         Location = request.Location,
        //         Description = request.Description,
        //         //Falta Employer.Username
        //         CategoryEnum = request.CategoryEnum,
        //     };

        //     return newJob;
        // }

        //Faltan demas firmas


    }
}