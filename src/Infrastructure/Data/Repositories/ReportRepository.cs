using Domain.Entities;
using Domain.Interfaces;
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


    }
}
