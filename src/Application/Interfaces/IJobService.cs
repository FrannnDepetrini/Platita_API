﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Application.Models;
using Application.Models.Requests;
using Application.Models.Responses;
using Domain.Constants;
using Domain.Entities;

namespace Application.Interfaces
{
    public interface IJobService
    {
        Task<List<JobDTO>> GetJobsByClientLocationAsync(int userId);
        Task<List<JobDTO>> GetJobsBySearchLocationAsync(string Province, string city, int userId);
        Task<IEnumerable<JobDTO>> GetJobsByCategory(JobFilteredByCategoryRequest request, int userId);
        Task<List<JobDTO>> GetJobsByClientAsync(int userId);
        Task<List<AllJobsDTO>> GetAllJobs();
        Task<List<JobDtoReport>> GetAllJobsReported();
        Task<JobDTO> GetJobById(int jobId, int userId);
        Task<JobDTO> Create(JobRequest request, int userId);
        Task<JobDTO> Update(JobUpdateRequest request, int id, int userId);
        Task Delete(int id, int userId);
        Task DeleteLogic(int id, int userId);
        Task JobFinished(int idJob, int userId);
        Task ResetJobCancellation(int idJob, int userId);

    }

}
