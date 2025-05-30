using Domain.Constants;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Org.BouncyCastle.Asn1.Mozilla;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Repositories
{
    public class ComplaintRepository : BaseRepository<Complaint>, IComplaintRepository
    {
        private new readonly ApplicationContext _context;

        public ComplaintRepository(ApplicationContext context) : base(context)
        {
            _context = context;
        }

        public async Task<List<Complaint>> GetAllComplaint()
        {
            return await _context.Complaints
                .Include(c => c.Client)
                .Where(c => c.Status == ComplaintStatusEnum.Pending)
                .OrderBy(c => c.CreatedAt)
                .ToListAsync();
        }
    }
}
