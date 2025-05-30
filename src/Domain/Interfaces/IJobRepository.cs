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
            Task<List<Job>> GetJobsByLocationAsync(string Province, string city, int userId);

            Task<List<Job>> GetByClientId(int userId);

            Task<IEnumerable<Job>> GetJobsByCategory(CategoryEnum category, int userId);

            // Los 2 de abajo son para Moderator
            Task<List<Job>> GetAllJobs();
            Task<List<Job>> GetAllJobsReported();

            Task<List<Job>> GetAllExpiratedJobs(CancellationToken cancellationToken);

            Task SaveChangesAsync();
        }
}
