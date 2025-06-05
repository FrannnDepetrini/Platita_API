using Application.Models.Requests;
using Application.Models.Responses;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IRatingService
    {
        Task<List<RatingDTO>> GetMyOrOtherReceivedRatingsForEmployer(int clientId);
        Task<List<RatingDTO>> GetMyOrOtherReceivedRatingsForEmployee(int clientId);
        Task<List<object>> GetMyReceivedRatingsScore(int clientId);

        Task CreateRating(int clientId, CreateRatingRequest request);

        Task CreateBadRating(int clientId, CreateRatingRequest request);
        Task DeleteRatingPhysics(int idRating);
    }
}
