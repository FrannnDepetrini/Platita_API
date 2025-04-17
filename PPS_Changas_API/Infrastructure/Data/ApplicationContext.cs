using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Constants;

namespace Infrastructure.Data
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Job> Jobs { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }

        //Trabajos para testear db y endpoints de delete/deleteLogic
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //ignora claves foraneas
            //modelBuilder.Entity<Job>().Ignore(j => j.Employer);
            modelBuilder.Entity<Job>().Ignore(j => j.Postulations);

            modelBuilder.Entity<Job>().HasData(new Job
            {
                Id = 1,
                Title = "Busco electricista",
                EmployerName = "Juan",
                Available = true,
                Location = "Rosario",
                Description = "busco electricista para que me cambie una lamparita",
                Category = CategoryEnum.Electricity,
                DateTime = DateTime.Now
            }, new Job
            {
                Id = 2,
                Title = "Busco plomero",
                EmployerName = "Maria",
                Available = true,
                Location = "Rosario",
                Description = "busco plomero para arreglar mi bano",
                Category = CategoryEnum.Plumbing,
                DateTime = DateTime.Now
            }, new Job
            {
                Id = 3,
                Title = "Busco Jardinero",
                EmployerName = "Marta",
                Available = true,
                Location = "Buenos Aires",
                Description = "necesito cortar el pasto",
                Category = CategoryEnum.Gardening,
                DateTime = DateTime.Now
            }

            );
        }

    }
}
