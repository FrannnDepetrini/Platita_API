using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class JobRepository : BaseRepository<Job>, IJobRepository
    {
        private readonly ApplicationContext _context;

        public JobRepository(ApplicationContext context) : base(context) 
        { 
            _context = context;
        }
    }
}
