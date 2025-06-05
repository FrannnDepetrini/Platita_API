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
    public class Report
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        public DateTime Created_At { get; set; }
        public CategoryReport CategoryReport { get; set; }
        public int JobId { get; set; }
        public int ClientId { get; set; }
        public Job Job { get; set; }
        public Client Client { get; set; }
    }
}
