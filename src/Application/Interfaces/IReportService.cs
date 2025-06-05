using Application.Models.Responses;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IReportService
    {
        Task<List<JobReportSummaryDTO>> GetJobReportSummariesAsync();
        Task DeleteReportedJob(int jobId);
        Task CleanReportedJob(int jobId);

        Task AddReport(int userId, int jobId, string category);
    }
}
