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
        public DbSet<User> Users { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<Postulation> Postulations { get; set; }
        public DbSet<Complaint> Complaints { get; set; }
        public DbSet<Payment> Payments { get; set; }

        // Esto de acá no crea todas estas tablas sino que las hace disponibles para consultas en vez de tener que llamar a la tabla Users
        public DbSet<SysAdmin> SysAdmins { get; set; }
        public DbSet<Moderator> Moderators { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Support> Supports { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }

        //Trabajos para testear db y endpoints de delete/deleteLogic
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //  acá le digo a la tabla User que va a tener una columna que sirve para discriminar el tipo de User
            modelBuilder.Entity<User>()
                .HasDiscriminator<string>("Role")
                .HasValue<SysAdmin>("SysAdmin")
                .HasValue<Moderator>("Moderator")
                .HasValue<Client>("Client")
                .HasValue<Support>("Support");


            modelBuilder.Entity<Job>()
                .HasOne(j => j.Client)
                .WithMany(c => c.Jobs)
                .HasForeignKey(j => j.ClientId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Postulation>()
               .HasOne(j => j.Client)
               .WithMany(c => c.Postulations)
               .HasForeignKey(j => j.ClientId)
               .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Client>()
                .HasMany(c => c.Ratings)
                .WithOne()
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Job>()
                .HasMany(j => j.Postulations)
                .WithOne(p => p.Job)
                .HasForeignKey(p => p.JobId);

            modelBuilder.Entity<Complaint>()
                .HasOne(c => c.Client)
                .WithMany()
                .HasForeignKey(c => c.ClientId);

            modelBuilder.Entity<Complaint>()
                .HasOne(c => c.Support)
                .WithMany(s => s.Complaints)
                .HasForeignKey(c => c.SupportId);

            modelBuilder.Entity<Rating>()
                .HasOne(r => r.Job)
                .WithMany()
                .HasForeignKey(r => r.JobId);

            //modelBuilder.Entity<Payment>().HasData(new Payment
            //{
            //    Id = 1,
            //    Type = PaymentEnum.MercadoPago,
            //    Description = "podes pagar con mp"
            //});
            //ignora claves foraneas
            //modelBuilder.Entity<Job>().Ignore(j => j.Employer);
            //modelBuilder.Entity<Job>().Ignore(j => j.Postulations);

            // Esto lo agrego para que en la tabla Users no me agregue las columnas SysAdminId y ModeratorId
            // Despues hay que ver bien si en las entidades SysAdmin y Moderator hace falta que tenga una lista de Users
            //modelBuilder.Entity<SysAdmin>().Ignore(s => s.Users);
            //modelBuilder.Entity<Moderator>().Ignore(s => s.Users);
            modelBuilder.Entity<Client>().HasData(new Client
            {
                Id = 4,
                State = "Santa Fe",
                City = "Rosario",
                Email = "marmax0504@gmail.com",
                UserName = "Maximo",
                Password = "1234",
                PhoneNumber = 341,
                
            }
                );
        //modelBuilder.Entity<Job>().HasData(new Job
        //{
        //    Id = 1,
        //    Title = "Busco electricista",
        //    EmployerName = "Juan",
        //    Available = true,
        //    Location = "Rosario",
        //    Description = "busco electricista para que me cambie una lamparita",
        //    Category = CategoryEnum.Electricity,
        //    DateTime = DateTime.Now
        //}, new Job
        //{
        //    Id = 2,
        //    Title = "Busco plomero",
        //    EmployerName = "Maria",
        //    Available = true,
        //    Location = "Rosario",
        //    Description = "busco plomero para arreglar mi bano",
        //    Category = CategoryEnum.Plumbing,
        //    DateTime = DateTime.Now
        //}, new Job
        //{
        //    Id = 3,
        //    Title = "Busco Jardinero",
        //    EmployerName = "Marta",
        //    Available = true,
        //    Location = "Buenos Aires",
        //    Description = "necesito cortar el pasto",
        //    Category = CategoryEnum.Gardening,
        //    DateTime = DateTime.Now
        //}

        //);
    }

    }
}
