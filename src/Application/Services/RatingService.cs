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


        public async Task DeleteRatingFisic(int idRating)
        {
            var rating = await _ratingRepository.GetById(idRating);
            await _ratingRepository.Delete(rating);
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
            var job = await _jobRepository.GetById(request.JobId);

            var newRating = new Rating
            {
                RatedByUserId = null,
                RatedUserId = job.ClientId == clientId ? job.PostulationSelected.ClientId : job.ClientId,
                Score = request.Score,
                Description = request.Description,
                JobId = request.JobId,
            };

            await _ratingRepository.Create(newRating);

        }
        /*public int RatedByUserId { get; set; } //hace la reseña. token
        public int RatedUserId { get; set; } //recibe reseña. empleador -> job.client.id
                                             //               empleado -> job.postulation.id
        public int Score { get; set; }
        public string Description { get; set; }

        public int JobId { get; set; }

        public Job Job { get; set; }*/

    }
}
