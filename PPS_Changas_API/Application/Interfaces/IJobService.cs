using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Application.Models;
using Application.Models.Requests;
using Application.Models.Responses;
using Domain.Entities;

namespace Application.Interfaces
{
    public interface IJobService
{
    //Task<JobsDTO> GetById(int id);
    Task<JobDTO> Create(JobRequest request, ClaimsPrincipal user);
    Task<JobDTO> Update(JobUpdateRequest request, int id, ClaimsPrincipal user);
    Task Delete(int id, ClaimsPrincipal user);
    Task DeleteLogic(int id, ClaimsPrincipal user);
}

}
