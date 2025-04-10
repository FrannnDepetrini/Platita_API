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
        public string Title { get; set; }
        public float Price { get; set; }
        public string DateTime { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public CategoryEnum CategoryEnum {get; set;}
    }
}
