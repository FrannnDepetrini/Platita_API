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

        public async Task<List<Rating>> GetMyReceivedRatings(int clientId)
        {
            return await _context.Ratings.Where(r => r.RatedUserId == clientId).ToListAsync();
        }

        public async Task<Dictionary<int, int>> GetMyReceivedRatingsScore(int clientId)
        {
            var ratings = await _context.Ratings
                                .Where(r => r.RatedUserId == clientId)
                                .ToListAsync();

            var distribution = ratings
                .GroupBy(r => r.Score)
                .ToDictionary(g => g.Key, g => g.Count());

            for (int i = 1; i <= 5; i++)
            {
                if (!distribution.ContainsKey(i))
                    distribution[i] = 0;
            }

            return distribution.OrderByDescending(kvp => kvp.Key)
                               .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
        }

    }
}
