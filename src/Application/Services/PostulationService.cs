﻿using Application.Interfaces;
using Application.Models.Requests;
using Application.Models.Responses;
using Domain.Constants;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class PostulationService(IPostulationRepository postulationRepository, IJobRepository jobRepository, IRatingService ratingService, IEmailService emailService) : IPostulationService
    {
        private readonly IPostulationRepository _postulationRepository = postulationRepository;
        private readonly IJobRepository _jobRepository = jobRepository;
        private readonly IRatingService _ratingService = ratingService;
        private readonly IEmailService _emailService = emailService;


       
        public async Task<IEnumerable<PostulationDetailDTO>> GetPostulationsByJobIdAsync(int jobId, int publisherId)
        {
            var postulation = await _postulationRepository.GetByJobIdAsync(jobId);

            if (postulation is null)
            {
                throw new Exception("Job not found");
            }

            var firstPostulation = postulation.FirstOrDefault();

            if (firstPostulation == null)
            {
                throw new Exception("No hay postulaciones para este trabajo");
            }

            var job = firstPostulation.Job;

            if (job.ClientId != publisherId)
            {
                throw new UnauthorizedAccessException("No estas autorizado para ver las publicaciones");
            }

            return postulation.Select(PostulationDetailDTO.Create);

        }

        public async Task<PostulationDetailDTO> PostulateAsync(int userId, int jobId, float budget, DateTime jobDay)
        {
            var job = await _jobRepository.GetById(jobId);
            if (job == null)
            {
                throw new Exception("Trabajo no encontrado");
            }

            if (job.ClientId == userId)
            {
                throw new Exception("No puede postular a su propio trabajo");
            }

            var isDuplicatePostulation = await _postulationRepository.CheckDuplicatePostulation(userId, jobId);

            if (isDuplicatePostulation)
            {
                throw new Exception("Ya te postulaste a este trabajo");
            }

            var postulation = new Postulation
            {
                JobId = jobId,
                ClientId = userId,
                Budget = budget,
                JobDay = jobDay,
                Status = PostulationStatusEnum.Pending
                
            };

            await _postulationRepository.Create(postulation);

            return PostulationDetailDTO.Create(postulation);
        }

        public async Task<PostulationDTO> ChangeStatusPostulation(int jobId, int postulantId, int userId)
        {
            var selectedPostulant = await _postulationRepository.GetPostulationByJobAndPostulantId(jobId, postulantId);

            if (selectedPostulant.Job.ClientId != userId)
            {
                throw new Exception("No autorizado");
            }



            if (selectedPostulant == null)
            {
                throw new Exception("Postulante no encontrado");
            }

            var allPostulations = await _postulationRepository.GetByJobIdAsync(jobId);

            

            if (allPostulations.FirstOrDefault(p => p.Status == PostulationStatusEnum.Success) != null)
            {
                throw new Exception("You already have one postulant");
            }

            if (selectedPostulant.Status == PostulationStatusEnum.Rejected)
            {
                throw new Exception("This postulant is already rejected");
            }


            foreach (var postulation in allPostulations)
            {   
                if (postulation.Id == selectedPostulant.Id)
                {
                    postulation.Status = PostulationStatusEnum.Success;
                    await _emailService.SendNotificationEmailAsync(postulation.Client.Email, postulation.Client.UserName, CategoryNotificationsEnum.PostulantSelected);
                }
                else
                {
                    postulation.Status = PostulationStatusEnum.Rejected;
                    await _emailService.SendNotificationEmailAsync(postulation.Client.Email, postulation.Client.UserName, CategoryNotificationsEnum.PostulantRejected);
                }                
            }
            selectedPostulant.Job.Status = JobStatusEnum.Taken;

            selectedPostulant.Job.PostulationSelectedId = selectedPostulant.Id; 

            await _postulationRepository.SaveChangesAsync();

            return new PostulationDTO
            {
                Id = selectedPostulant.Id,
                UserName = selectedPostulant.Client.UserName,
                Email = selectedPostulant.Client.Email,
                Province = selectedPostulant.Client.Province,
                City = selectedPostulant.Client.City,
                Phone = selectedPostulant.Client.PhoneNumber,
                Status = selectedPostulant.Status.ToString()
            };

        }

        public async Task<string> ShowPhoneForAcceptedPostulation(int postulationId, int userId)
        {
            var postulation = await _postulationRepository.GetById(postulationId);

            if (postulation == null)
                throw new Exception("Postulation not found");

            if (postulation.Status != PostulationStatusEnum.Success)
                throw new Exception("Postulation was not accepted");

            if (userId == postulation.ClientId)
            {
                return $"{postulation.Job.Client.PhoneNumber}";
            }
            else if (userId == postulation.Job.ClientId)
            {
                return $"{postulation.Client.PhoneNumber}";
            }
            else
            {
                throw new Exception("User not authorized");
            }
        }


        public async Task<bool> DeletePostulationFisica(Postulation postJob)
        {

            await _postulationRepository.Delete(postJob);
           
            return true;
        }
        public async Task<bool> DeletePostulationPhysics(int jobId, int postulationId)
        {
            var postJob = await _postulationRepository.GetPostulationByJobAndPostulantId(jobId, postulationId);

            if (postJob == null)
            {
                throw new Exception("Not found");
            }

            await _postulationRepository.Delete(postJob);
            await _postulationRepository.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeletePostulationLogic(int jobId, int postulationId)
        {
            var postJob = await _postulationRepository.GetPostulationByJobAndPostulantId(jobId, postulationId);

            if (postJob == null)
            {
                throw new Exception("Not found");
            }

            var allPostulations = await _postulationRepository.GetByJobIdAsync(jobId);

            foreach (var postulation in allPostulations)
            {
                if (postulation.Id == postJob.Id)
                {
                    postulation.Status = PostulationStatusEnum.Rejected;
                }

            }

            await _postulationRepository.SaveChangesAsync();
            return true;
        }

        public async Task<IEnumerable<MyPostulationDTO>> GetMyPostulations(int userId)
        {
            var posts = await _postulationRepository.GetAllMyPostulations(userId);
            

            var result = posts.Select(p => new MyPostulationDTO
            {
                Id = p.Id,
                Budget = p.Budget,
                Status = p.Status.ToString(),
                JobDay = p.JobDay,
                Job = new JobDTO
                {
                    Id = p.Job.Id,
                    UserName = p.Job.Client.UserName,
                    Title = p.Job.Title,
                    AveragePrice = p.Job.AveragePrice,
                    AmountPostulations = p.Job.AmountPostulations,
                    Status = p.Job.Status.ToString(),
                    Province = p.Job.Province,
                    City = p.Job.City,
                    DayPublicationStart = p.Job.DayPublicationStart,
                    DayPublicationEnd = p.Job.DayPublicationEnd,
                    Description = p.Job.Description,
                    Category = p.Job.Category.ToString()
                }
            }).ToList();

            return result;
        }

        public async Task CancelPostulation(int jobId, int postulationId, int userId)
        {
            
            var postulation = await _postulationRepository.GetById(postulationId);

            var job = await _jobRepository.GetById(jobId);

            if(job.Postulations.FirstOrDefault(p => p.Id == postulation.Id) == null) 
            { 
                throw new Exception("This postulation not found"); 
            }

            if (postulation.Status == PostulationStatusEnum.Success)
            {
                postulation.Status = PostulationStatusEnum.Cancelled;
                await _emailService.SendNotificationEmailAsync(postulation.Client.Email, postulation.Client.UserName, CategoryNotificationsEnum.PostulantCancelled);
                if ((DateTime.Now - postulation.JobDay).TotalHours <= 48)
                {
                    //resena mala para el postulante
                    var request = new CreateRatingRequest
                    {
                        Score = 1,
                        Description = "Cancelo a ultimo momento",
                        JobId = job.Id
                    };
                    await _ratingService.CreateBadRating(userId, request);
                }
                

                foreach(var post in job.Postulations.ToList())
                {
                    if(post.Status != PostulationStatusEnum.Cancelled) 
                    { 
                        await DeletePostulationFisica(post); 
                    }
                }

                job.Status = JobStatusEnum.Deleted;
                await _jobRepository.SaveChangesAsync();
            }
        }
    }
}
