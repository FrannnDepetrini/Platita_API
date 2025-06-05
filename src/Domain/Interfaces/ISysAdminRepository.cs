using Domain.Constants;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface ISysAdminRepository
    {
        Task<List<User>> GetAllUsers(int userId);
        Task<List<User>> GetAllUsersByRole(int userId, RolesEnum role);

    }
}
