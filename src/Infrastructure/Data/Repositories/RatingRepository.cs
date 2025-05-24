using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Repositories
{
    public class RatingRepository : BaseRepository<Rating>, IRatingRepository
    {

        private new readonly ApplicationContext _context;

        public RatingRepository(ApplicationContext context) : base(context)
        {
            _context = context;
        }
        // Criticas por empleador
        public async Task<List<Rating>> GetMyOrOtherReceivedRatingsForEmployer(int clientId)
        {
            return await _context.Ratings
                .Include(j => j.Job)
                    .ThenInclude(p => p.PostulationSelected)
                    .ThenInclude(c => c.Client)
                .Include(c => c.Job)
                    .ThenInclude(c => c.Client)
                .Where(r => r.RatedUserId == clientId && r.Job.ClientId == clientId)
                .ToListAsync();
        }
        // Criticas por empleado
        public async Task<List<Rating>> GetMyOrOtherReceivedRatingsForEmployee(int clientId)
        {
            return await _context.Ratings
                .Include(j => j.Job)
                    .ThenInclude(p => p.PostulationSelected)
                    .ThenInclude(c => c.Client)
                .Include(c => c.Job)
                    .ThenInclude(c => c.Client)
                .Where(r => r.RatedUserId == clientId && r.Job.PostulationSelected.ClientId == clientId)
                .ToListAsync();
        }

        // Score
        public async Task<List<object>> GetMyReceivedRatingsScore(int clientId)
        {
            var ratings = await _context.Ratings
                .Include(j => j.Job)
                .ThenInclude(p => p.PostulationSelected)
                .Where(r => r.RatedUserId == clientId)
                .ToListAsync();

            var employerRatings = ratings
                .Where(r => r.Job.ClientId == clientId)
                .ToList();

            var employeeRatings = ratings
                .Where(r => r.Job.PostulationSelected != null && r.Job.PostulationSelected.ClientId == clientId)
                .ToList();

            var employerDistribution = employerRatings
                .GroupBy(r => r.Score)
                .ToDictionary(g => g.Key, g => g.Count());

            var employeeDistribution = employeeRatings
                .GroupBy(r => r.Score)
                .ToDictionary(g => g.Key, g => g.Count());

            for (int i = 1; i <= 5; i++)
            {
                if (!employerDistribution.ContainsKey(i))
                    employerDistribution[i] = 0;
            }
            for (int i = 1; i <= 5; i++)
            {
                if (!employeeDistribution.ContainsKey(i))
                    employeeDistribution[i] = 0;
            }

            var distributionList = new List<object>
            {
                new { Role = "Employer", Ratings = employerDistribution },
                new { Role = "Employee", Ratings = employeeDistribution }
            };

            return distributionList;
                
        }

    }
}
