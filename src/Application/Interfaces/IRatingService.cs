using Application.Models.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IRatingService
    {
        Task DeleteRatingFisic(int idRating);

        Task CreateRating(int clientId, CreateRatingRequest request);

        Task CreateBadRating(int clientId, CreateRatingRequest request);
    }
}
