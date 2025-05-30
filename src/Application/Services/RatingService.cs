using Application.Interfaces;
using Application.Models.Requests;
using Application.Models.Responses;
using Domain.Entities;
using Domain.Interfaces;
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

                var newRating = new Rating
                {
                    RatedByUserId = clientId,
                    RatedUserId = job.ClientId == clientId ? job.PostulationSelected.ClientId : job.ClientId,
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

        public async Task DeleteRatingFisic(int idRating)
        {
            var rating = await _ratingRepository.GetById(idRating);
            await _ratingRepository.Delete(rating);
        }

    }
}
