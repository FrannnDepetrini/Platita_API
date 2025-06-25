using Application.Interfaces;
using Application.Models.Requests;
using Application.Models.Responses;
using Domain.Entities;
using Domain.Interfaces;
using Domain.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class RatingService : IRatingService
    {
        private readonly IRatingRepository _ratingRepository;
        private readonly IJobRepository _jobRepository;
        private readonly IPostulationRepository _postulationRepository;

        public RatingService(IRatingRepository ratingRepository, IJobRepository jobRepository, IPostulationRepository postulationRepository)
        {
            _ratingRepository = ratingRepository;
            _jobRepository = jobRepository;
            _postulationRepository = postulationRepository;
        }

        public async Task<List<RatingDTO>> GetMyOrOtherReceivedRatingsForEmployer(int clientId)
        {
            var ratings = await _ratingRepository.GetMyOrOtherReceivedRatingsForEmployer(clientId);

            var ratingsDto = ratings.Select(RatingDTO.Create).ToList();

            return ratingsDto;
        } 
        public async Task<List<RatingDTO>> GetMyOrOtherReceivedRatingsForEmployee(int clientId)
        {
            var ratings = await _ratingRepository.GetMyOrOtherReceivedRatingsForEmployee(clientId);

            var ratingsDto = ratings.Select(RatingDTO.Create).ToList();

            return ratingsDto;
        }

        public async Task<List<object>> GetMyReceivedRatingsScore(int clientId)
        {
            var ratings = await _ratingRepository.GetMyReceivedRatingsScore(clientId);
            return ratings;
        }

        public async Task CreateRating(int clientId, CreateRatingRequest request)
        {
            var job = await _jobRepository.GetById(request.JobId);

            if(job.ClientId != clientId && job.PostulationSelected.ClientId != clientId)
                throw new Exception("you are not allowed to create a rating");
            if (job.Status != JobStatusEnum.Done)
                throw new Exception("Job is not done");

            // id del que recibe la reseña, que puede ser el dueño del trabajo o el empleado
            var idReviewed = (job.ClientId == clientId) ? job.PostulationSelected.ClientId : job.ClientId;

            var existingReview = await _ratingRepository.GetExistingReviewForUser(clientId, idReviewed, job.Id);

            if (existingReview)
                throw new Exception("You have already rated this client");

            if (!job.DateJobFinished.HasValue)
                throw new Exception("Job doesn't have a finish date");

            var now = DateOnly.FromDateTime(DateTime.Today);
            var days = (now.ToDateTime(TimeOnly.MinValue) - job.DateJobFinished.Value.ToDateTime(TimeOnly.MinValue)).Days;

            if (days > 10)
                throw new Exception("You can't review now");


            var newRating = new Rating
            {
                RatedByUserId = clientId,
                RatedUserId = idReviewed,
                Score = request.Score,
                Description = request.Description,
                JobId = request.JobId,
            };

            await _ratingRepository.Create(newRating);

        }

        public async Task CreateBadRating(int clientId, CreateRatingRequest request)
        {

            var newRating = new Rating
            {
                RatedByUserId = null,
                RatedUserId = clientId,
                Score = request.Score,
                Description = request.Description,
                JobId = request.JobId,
            };

            await _ratingRepository.Create(newRating);

        }

        public async Task DeleteRatingPhysics(int idRating)
        {
            var rating = await _ratingRepository.GetById(idRating);
            await _ratingRepository.Delete(rating);
        }

    }
}
