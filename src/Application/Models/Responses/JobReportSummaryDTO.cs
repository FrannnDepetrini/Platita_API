using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models.Responses
{


    public class JobReportSummaryDTO
    {
        public int JobId { get; set; }
        public int TotalReports { get; set; }
        public List<CategoryCountDTO> ReportsByCategory { get; set; }

        //public static JobReportSummaryDTO Create(Report report) 
        //{
        //    return new JobReportSummaryDTO
        //    {
        //        JobId = report.JobId,
        //        TotalReports = report.
        //    };
        //}
    }



}
