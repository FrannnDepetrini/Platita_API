using Domain.Constants;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Postulation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int JobId { get; set; }
        public float Budget { get; set; }
        public Job Job { get; set; }
        public Client Client { get; set; }

        public DateTime JobDay { get; set; }
        public PostulationStatusEnum Status { get; set; }

    }
}
