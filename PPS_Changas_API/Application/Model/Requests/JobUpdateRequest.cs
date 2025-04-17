using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Constants;

namespace Application.Model.Requests
{
    public class JobUpdateRequest
    {
        public string EmployerName {get; set;} //Tendria que ir la entidad employer
        public string Title { get; set; }
        //public float AveragePrice { get; set; }
        public DateTime DateTime { get; set; } = DateTime.Today;
        public string Location { get; set; }
        public string Description { get; set; }
        public CategoryEnum CategoryEnum {get; set;}
    }
}
