using Application.Interfaces;
using Domain.Constants;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class JobExpirationService : IJobExpirationService
    {
        private readonly IJobRepository _jobRepository;

        public JobExpirationService(IJobRepository jobRepository)
        {
            _jobRepository = jobRepository;
        }

        public async Task CheckAndExpireJobsAsync(CancellationToken cancellationToken)
        {
            var jobs = await _jobRepository.GetAllExpiratedJobs(cancellationToken);

            foreach (var job in jobs)
            {
                job.Status = JobStatusEnum.Deleted;
            }

            if (jobs.Count > 0)
            {
                await _jobRepository.SaveChangesAsync();
            }
        }
    }
}