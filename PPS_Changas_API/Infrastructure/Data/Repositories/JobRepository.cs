using Application.Models.Responses;
using Domain.Constants;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Net.Http.Headers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Repositories
{
    public class JobRepository : BaseRepository<Job>, IJobRepository
    {
        private readonly ApplicationContext _context;

        public JobRepository(ApplicationContext context) : base(context)
        {
            _context = context;
        }

        public override async Task<Job?> GetById(int id)
        {
            return await _context.Jobs
                .Include(j => j.Client)
                .Include(j => j.Postulations)
                .FirstOrDefaultAsync(j => j.Id == id);
        }

        public async Task<IEnumerable<Job>> GetJobsByCategory(CategoryEnum category)
        {
            return await _context.Set<Job>()
                                .Where(j => j.Category == category)
                                .ToListAsync();
        }
    }
}
