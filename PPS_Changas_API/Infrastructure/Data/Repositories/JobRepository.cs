using Application.Models.Responses;
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
    public class JobRepository : BaseRepository<Job>, IJobRepository
    {
        private readonly ApplicationContext _context;

        public JobRepository(ApplicationContext context) : base(context) 
        { 
            _context = context;
        }

        public override async Task<Job?> GetById(int id)
        {
            return await _context.Jobs
                .Include(j => j.Client)
                .Include(j => j.Postulations)
                .FirstOrDefaultAsync(j => j.Id == id);
        }
    }
}
