using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Repositories
{
    public class PostulationRepository : BaseRepository<Postulation>, IPostulationRepository
    {
        private readonly ApplicationContext _context;
        public PostulationRepository(ApplicationContext context) : base(context)
        {
            _context = context;
        }

        public Task<Postulation?> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Postulation>> GetByJobIdAsync(int jobId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Postulation>> GetByUserIdAsync(int userId)
        {
            throw new NotImplementedException();
        }

    }
}
