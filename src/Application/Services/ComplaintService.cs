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
    public class ComplaintService : IComplaintService
    {
        private readonly IComplaintRepository _complaintRepository;

        public ComplaintService(IComplaintRepository complaintRepository)
        {
            _complaintRepository = complaintRepository;
        }

        public async Task<List<ComplaintDTO>> GetAllComplaint()
        {
            var complaint = await _complaintRepository.GetAllComplaint();

            return complaint.Select(ComplaintDTO.Create).ToList();
        }

        public async Task<Complaint> CreateComplaint(string description, int userId)
        {

            var complaint = new Complaint()
            {
                ClientId = userId,
                Description = description,
                Status = ComplaintStatusEnum.Pending,
                CreatedAt = DateTime.Now
            };

            return await _complaintRepository.Create(complaint);
        }

        public async Task CompleteComplaint(int complaintId)
        {
            var complaint = await _complaintRepository.GetById(complaintId);

            complaint.Status = ComplaintStatusEnum.Solved;

            await _complaintRepository.Update(complaint);
        }
    }
}
