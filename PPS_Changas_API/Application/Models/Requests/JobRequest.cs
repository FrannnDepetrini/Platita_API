using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Constants;

namespace Application.Models.Requests
{
    public class JobRequest
    {
        public string Title { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Description { get; set; }
        public string Category {get; set;}
        public DateTime? DateTime { get; set; }
        public string Picture { get; set; }
    }
}

// Flight flight1 = new Flight
//             {
//                 DateGo = flight.DateGo ?? flightFound.DateGo,
//                 TimeDepartureGo = flight.TimeDepartureGo ?? flightFound.TimeDepartureGo,
//                 TimeArrivalGo = flight.TimeArrivalGo ?? flightFound.TimeArrivalGo ,
//                 DateBack = flight.DateBack ?? flightFound.DateBack,
//                 TimeDepartureBack = flight.TimeDepartureBack ?? flight.TimeDepartureGo,
//                 TimeArrivalBack = flight.TimeArrivalBack ?? flightFound.TimeArrivalBack,
//             };

