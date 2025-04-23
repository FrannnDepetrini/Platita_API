using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Constants;

namespace Application.Model.Requests
{
    public class JobRequest
    {
        public string EmployerName {get; set;}
        public string Title { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public CategoryEnum Category {get; set;}
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

