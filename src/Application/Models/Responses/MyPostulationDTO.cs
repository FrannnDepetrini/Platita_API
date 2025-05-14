using Domain.Constants;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models.Responses;

public class MyPostulationDTO
{
    public int Id { get; set; }
    public float Budget { get; set; }
    public JobDTO Job { get; set; }
    public Client Client { get; set; }
    public string Status { get; set; }


    public static MyPostulationDTO? Create(Postulation postulation)
    {
        if (postulation == null)
        {
            return null;
        }

        return new MyPostulationDTO
        {
            Id = postulation.Id,
            Budget = postulation.Budget,
            Job = JobDTO.Create(postulation.Job),
            Status = postulation.Status.ToString()
        };
    }
}

