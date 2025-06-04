using Domain.Constants;
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
    public class SysAdminRepository : BaseRepository<SysAdmin>, ISysAdminRepository
    {
        private new readonly ApplicationContext _context;

        public SysAdminRepository(ApplicationContext context) : base(context)
        {
            _context = context;
        }

        public async Task<List<User>> GetAllUsers(int userId)
        {
            return await _context.Users
                .Where(u => u.Id != userId)
                .ToListAsync();
        }

        public async Task<List<User>> GetAllUsersByRole( int userId, RolesEnum role)
        {
            return await _context.Users
                .Where(u => u.Id != userId)
                .Where(u => u.Role == role)
                .ToListAsync();
        }


    }
}
