using Domain.Constants;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models.Responses
{
    public class ReportDTO
    {
        public int Id { get; set; }
        public DateTime Created_At { get; set; }
        public string CategoryReport { get; set; }

        public int ClientId { get; set; }


        public static ReportDTO Create(Report report)
        {
            if (report == null) return null;

            return new ReportDTO
            {
                Id = report.Id,
                Created_At = report.Created_At,
                CategoryReport = report.CategoryReport.ToString(),
                ClientId = report.ClientId
            };

        }
    }
}
