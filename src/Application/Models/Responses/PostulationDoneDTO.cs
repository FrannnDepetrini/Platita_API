using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models.Responses;

public class PostulationDoneDTO
{
    public string JobTitle { get; set; }
    public string EmployerName { get; set; }
    public string Category {  get; set; }
    public DateOnly DateJobFinished { get; set; }
}
