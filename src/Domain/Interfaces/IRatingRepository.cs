using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IRatingRepository : IBaseRepository<Rating> 
    {
        Task<List<Rating>> GetMyOrOtherReceivedRatingsForEmployer(int clientId);
        Task<List<Rating>> GetMyOrOtherReceivedRatingsForEmployee(int clientId);
        Task<List<object>> GetMyReceivedRatingsScore(int clientId);
    }
}
