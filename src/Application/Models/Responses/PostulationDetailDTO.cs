﻿using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models.Responses
{
    public class PostulationDetailDTO
    {
        public int Id { get; set; }
        public float Budget { get; set; }
        public DateTime JobDay { get; set; }
        public string Status { get; set; }
        public ClientForJobDTO Client { get; set; }
        
        internal static PostulationDetailDTO? Create(Postulation postulation)
        {
            if (postulation == null)
            {
                return null;
            }

            return new PostulationDetailDTO
            {
                Id = postulation.Id,
                Budget = postulation.Budget,
                JobDay = postulation.JobDay,
                Status = postulation.Status.ToString(),
                Client = ClientForJobDTO.Create(postulation.Client)!
            };
        }

    
    }
}
