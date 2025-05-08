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

        Task<IEnumerable<Job>> GetJobsByCategory(CategoryEnum category);


        Task<List<Job>> GetJobsByLocationAsync(string state, string city);

    }
}
