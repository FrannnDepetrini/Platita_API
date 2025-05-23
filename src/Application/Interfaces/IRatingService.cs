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
        Task<List<Rating>> GetMyReceivedRatings(int clientId);
        Task<Dictionary<int, int>> GetMyReceivedRatingsScore(int clientId);

        Task CreateRating(int clientId, CreateRatingRequest request);

        Task CreateBadRating(int clientId, CreateRatingRequest request);
        Task DeleteRatingFisic(int idRating);
    }
}
