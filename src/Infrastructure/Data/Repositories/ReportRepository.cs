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
    public class ReportRepository : BaseRepository<Report>, IReportRepository
    {
        private new readonly ApplicationContext _context;

        public ReportRepository(ApplicationContext context) : base(context)
        {
            _context = context;
        }

        public async Task DeleteByJobId(int jobId)
        {
            var reports = _context.Reports.Where(r => r.JobId == jobId);
            _context.Reports.RemoveRange(reports);
            await _context.SaveChangesAsync();
        }


        public async Task<bool> GetReportByUserAndJob(int userId, int jobId)
        {
            return await _context.Reports.AnyAsync(r => r.ClientId == userId && r.JobId == jobId);
        }

    }
}
