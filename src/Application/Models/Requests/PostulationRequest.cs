using Domain.Constants;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models.Requests;

public class PostulationRequest
{
    public int JobId { get; set; }
    public float Budget { get; set; }

    public DateTime jobDay { get; set; }
}
