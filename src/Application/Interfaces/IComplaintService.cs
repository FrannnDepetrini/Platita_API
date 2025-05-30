using Application.Models.Requests;
using Application.Models.Responses;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IComplaintService
    {
        Task<List<ComplaintDTO>> GetAllComplaint();
        Task<Complaint> CreateComplaint(string description, int userId);
        Task CompleteComplaint(int complaintId);
    }
}
