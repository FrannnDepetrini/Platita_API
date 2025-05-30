using Domain.Constants;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
        public interface IJobRepository : IBaseRepository<Job>
        {
            Task<List<Job>> GetJobsByLocationAsync(string Province, string city);

            Task<List<Job>> GetByClientId(int userId);

            Task<IEnumerable<Job>> GetJobsByCategory(CategoryEnum category);

            Task<List<Job>> GetAllJobs();

            Task<List<Job>> GetAllJobsReported();

            Task<List<Job>> GetAllExpiratedJobs(CancellationToken cancellationToken);

            Task SaveChangesAsync();
        }
}
