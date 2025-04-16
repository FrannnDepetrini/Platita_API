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
        // Task<List<JobsDTO>> GetAll();
        // JobsDTO GetById(int id);
        // Job Create(JobRequest request);
        // Job Update(JobUpdateRequest request);
        Task Delete (int id);
        Task DeleteLogic (int id);
    }
}
