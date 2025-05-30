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
        private new readonly ApplicationContext _context;

        public JobRepository(ApplicationContext context) : base(context)
        {
            _context = context;
        }

        public override async Task<Job?> GetById(int id)
        {
            return await _context.Jobs
                .Include(j => j.Client)
                .Include(j => j.Postulations)
                .Include(j => j.PostulationSelected)
                .FirstOrDefaultAsync(j => j.Id == id);
        }

        public async Task<IEnumerable<Job>> GetJobsByCategory(CategoryEnum category)
        {
            return await _context.Set<Job>()
            .Include(j => j.Client)
            .Include(j => j.Postulations)
            .Where(j => j.Category == category)
            .ToListAsync();
        }
        public async Task<List<Job>> GetJobsByLocationAsync(string Province, string city)
        {
            return await _context.Jobs
            .Include(j => j.Client)
            .Include(j => j.Postulations)
            .Where(j => j.Province == Province && j.City == city)
            .ToListAsync();
        }

        public async Task<List<Job>> GetByClientId(int userId)
        {
            return await _context.Jobs
            .Include(j => j.Client)
            .Include(j => j.Postulations)
            .Where(j => j.ClientId == userId)
            .ToListAsync();
        }
        public async Task<List<Job>> GetAllJobs()
        {
            return await _context.Jobs
                .Include(j => j.Client)
                .Include(j => j.Postulations)
                .Include(j => j.Reports)
                .ToListAsync();
        }

        public async Task<List<Job>> GetAllJobsReported()
        {
            return await _context.Jobs
                .Include(j => j.Client)
                .Include(j => j.Postulations)
                .Include(j => j.Reports)
                .Where(j => j.Reports.Count() > 0)
                .OrderByDescending(j => j.Reports.Count)
                .ToListAsync();
        }

        public async Task<List<Job>> GetAllExpiratedJobs(CancellationToken cancellationToken)
        {
            return await _context.Jobs
                .Where(j => j.Status == JobStatusEnum.Available && j.DayPublicationEnd < DateTime.Now)
                .ToListAsync(cancellationToken);
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
