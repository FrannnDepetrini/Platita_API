using Application.Interfaces;
using Application.Models.Responses;
using Domain.Constants;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class ReportService(IReportRepository reportRepository, IJobRepository jobRepository) : IReportService 
    {
            private readonly  IReportRepository _reportRepository = reportRepository;
            private readonly IJobRepository _jobRepository = jobRepository;

        public async Task<List<JobReportSummaryDTO>> GetJobReportSummariesAsync()
        {
            var reports = await _reportRepository.GetAll();

            var result = reports
                .GroupBy(r => r.JobId)
                .Select(g => new JobReportSummaryDTO
                {
                    JobId = g.Key,
                    TotalReports = g.Count(),
                    ReportsByCategory = g
                        .GroupBy(r => r.CategoryReport)
                        .Select(cg => new CategoryCountDTO
                        {
                            Category = cg.Key.ToString(),
                            Count = cg.Count()
                        }).ToList()
                }).ToList();

            return result;
        }


        public async Task DeleteReportedJob(int jobId)
        {
            var job = await _jobRepository.GetById(jobId);
            await _jobRepository.Delete(job);
            
        }

        public async Task CleanReportedJob(int jobId)
        {
            await _reportRepository.DeleteByJobId(jobId);
        }

        public async Task AddReport(int userId, int jobId, string category)
        {
            if (!Enum.TryParse<CategoryReport>(category, ignoreCase: true, out var parsedCategory) ||
            !Enum.IsDefined(typeof(CategoryReport), parsedCategory))
            {
                throw new ArgumentException("Invalid report category");
            }

            var hasReported = await _reportRepository.GetReportByUserAndJob(userId, jobId);

            if (hasReported)
            {
                throw new Exception("You has already reported this job");
            }

            var report = new Report
            {
                JobId = jobId,
                ClientId = userId,
                Created_At = DateTime.UtcNow,
                CategoryReport = parsedCategory 
            };

            await _reportRepository.Create(report);
        }
    }
}
