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
        //Task<JobsDTO> GetById(int id);

        Task<JobDTO> Create(JobRequest request, int userId);
        Task<JobDTO> Update(JobUpdateRequest request, int id, int userId);
        Task Delete(int id, int userId);
        Task DeleteLogic(int id, int userId);
        //Task GetJobsByClientLocationAsync(int userId);
        Task<List<JobDTO>> GetJobsByClientLocationAsync(int userId);
            //Task JobByLocationRequest(string city, string Province);
        Task<List<JobDTO>> GetJobsBySearchLocationAsync(string Province, string city);
    
        Task<List<JobDTO>> GetJobsByClientAsync(int userId);
        Task<IEnumerable<JobDTO>> GetJobsByCategory(JobFilteredByCategoryRequest request);

        Task JobFinished(int idJob, int userId);
    }

}
