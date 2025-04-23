using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Model;
using Application.Model.Requests;
using Domain.Entities;

namespace Application.Interfaces
{
    public interface IJobService
{
    //Task<JobsDTO> GetById(int id);
    Task<Job> Create(JobRequest request);
    Task<Job> Update(JobUpdateRequest request, int id);
    Task Delete(int id);
    Task DeleteLogic(int id);
}

}
