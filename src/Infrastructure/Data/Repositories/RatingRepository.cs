using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Repositories
{
    public class RatingRepository : BaseRepository<Rating>, IRatingRepository
    {

        private new readonly ApplicationContext _context;

        public RatingRepository(ApplicationContext context) : base(context)
        {
            _context = context;
        }

    }
}
