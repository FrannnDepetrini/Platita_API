using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Constants;
using Infrastructure.Services;

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

            //modelBuilder.Entity<User>().HasIndex(u => u.Email).IsUnique();
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

            modelBuilder.Entity<Job>()
                .HasOne(c => c.Payment)
                .WithMany()
                .HasForeignKey(c => c.PaymentId);

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

            // PAYMENT
            modelBuilder.Entity<Payment>().HasData(
                new Payment
                {
                    Id = 1,
                    Type = PaymentEnum.MercadoPago,
                    Description = "Pagos digitales a través de MercadoPago. Rápido y seguro."
                },
                new Payment
                {
                    Id = 2,
                    Type = PaymentEnum.Transference,
                    Description = "Transferencia bancaria directa a la cuenta indicada por el usuario."
                }
            );

            // CLIENTES (IDs: 4 al 10)
            modelBuilder.Entity<Client>().HasData(new Client
                {
                    Id = 4,
                    Province = "Santa Fe",
                    City = "Rosario",
                    Email = "marmax0504@gmail.com",
                    UserName = "Maximo Martin",
                    Password = BCrypt.Net.BCrypt.HashPassword("123"),
                    PhoneNumber = "3496502453",

                }, new Client
                {
                    Id = 5,
                    Province = "Buenos Aires",
                    City = "La Plata",
                    Email = "joako.tanlon@gmail.com",
                    UserName = "Joaquin Tanlongo",
                    Password = BCrypt.Net.BCrypt.HashPassword("456"),
                    PhoneNumber = "3412122907",
                }, new Client
                {
                    Id = 6,
                    Province = "Santa Fe",
                    City = "Rosario",
                    Email = "marucomass@gmail.com",
                    UserName = "Mario Massonnat",
                    Password = BCrypt.Net.BCrypt.HashPassword("789"),
                    PhoneNumber = "3467637190",
                },
                new Client
                {
                    Id = 7,
                    Province = "Córdoba",
                    City = "Marcos Juarez",
                    Email = "frandepe7@gmail.com",
                    UserName = "Francisco Depetrini",
                    Password = BCrypt.Net.BCrypt.HashPassword("111"),
                    PhoneNumber = "3472582334"
                },
                new Client
                {
                    Id = 8,
                    Province = "Santa Fe",
                    City = "Firmat",
                    Email = "palenafrancisco@gmail.com",
                    UserName = "Francisco Palena",
                    Password = BCrypt.Net.BCrypt.HashPassword("222"),
                    PhoneNumber = "3465664518"
                },
                new Client
                {
                    Id = 9,
                    Province = "Santa Fe",
                    City = "Bigand",
                    Email = "pedrogasparini99@gmail.com",
                    UserName = "Pedro Gasparini",
                    Password = BCrypt.Net.BCrypt.HashPassword("333"),
                    PhoneNumber = "3464445164"
                }
            );


            // JOBS (IDs: 1 al 4)
            modelBuilder.Entity<Job>().HasData(
                new Job
                {
                    Id = 1,
                    ClientId = 4, // Maximo
                    Title = "Pintar departamento",
                    Status = JobStatusEnum.Available,
                    Description = "Necesito pintar un monoambiente en el centro",
                    Category = CategoryEnum.Painter,
                    Province = "Santa Fe",
                    City = "Rosario",
                    DayPublicationStart = new DateTime(2025, 5, 15),
                    DayPublicationEnd = new DateTime(2025, 5, 24),
                    PaymentId = 1
                },
                new Job
                {
                    Id = 2,
                    ClientId = 4, // Maximo
                    Title = "Instalación de luces LED",
                    Status = JobStatusEnum.Available,
                    Description = "Instalación de 10 luces LED en cocina y living",
                    Category = CategoryEnum.Electricity,
                    Province = "Santa Fe",
                    City = "Rosario",
                    DayPublicationStart = new DateTime(2025, 5, 13),
                    DayPublicationEnd = new DateTime(2025, 5, 20),
                    PaymentId = 1
                },
                new Job
                {
                    Id = 3,
                    ClientId = 5, // Joaquin
                    Title = "Corte de pasto y desmalezado",
                    Status = JobStatusEnum.Available,
                    Description = "Patio de 100m2 con pasto alto, se necesita corte y limpieza",
                    Category = CategoryEnum.Gardening,
                    Province = "Buenos Aires",
                    City = "La Plata",
                    DayPublicationStart = new DateTime(2025, 5, 15),
                    DayPublicationEnd = new DateTime(2025, 5, 18),
                    PaymentId = 1
                },
                new Job
                {
                    Id = 4,
                    ClientId = 6, // Mario
                    Title = "Reparar cañería del baño",
                    Status = JobStatusEnum.Available,
                    Description = "Hay una pérdida debajo del lavabo",
                    Category = CategoryEnum.Plumbing,
                    Province = "Mendoza",
                    City = "Godoy Cruz",
                    DayPublicationStart = new DateTime(2025, 5, 17),
                    DayPublicationEnd = new DateTime(2025, 5, 23),
                    PaymentId = 1
                },
                new Job
                {
                    Id = 5,
                    ClientId = 6, // Mario
                    Title = "Mudanza de muebles",
                    Status = JobStatusEnum.Available,
                    Description = "Necesito ayuda para mudar muebles pesados",
                    Category = CategoryEnum.Moving,
                    Province = "Santa Fe",
                    City = "Rosario",
                    DayPublicationStart = new DateTime(2025, 5, 17),
                    DayPublicationEnd = new DateTime(2025, 5, 22),
                    PaymentId = 1
                },
                new Job
                {
                    Id = 6,
                    ClientId = 7, // Depe
                    Title = "Corte de césped y limpieza del jardín",
                    Status = JobStatusEnum.Available,
                    Description = "Jardín de 50m2 con césped crecido",
                    Category = CategoryEnum.Gardening,
                    Province = "Córdoba",
                    City = "Marcos Juarez",
                    DayPublicationStart = new DateTime(2025, 5, 16),
                    DayPublicationEnd = new DateTime(2025, 5, 20),
                    PaymentId = 1
                },
                new Job
                {
                    Id = 7,
                    ClientId = 8, // Pale
                    Title = "Limpieza de hogar",
                    Status = JobStatusEnum.Available,
                    Description = "Limpieza profunda de casa de 3 ambientes",
                    Category = CategoryEnum.Cleaning,
                    Province = "Santa Fe",
                    City = "Firmat",
                    DayPublicationStart = new DateTime(2025, 4, 21),
                    DayPublicationEnd = new DateTime(2025, 4, 26),
                    PaymentId = 1
                },
                new Job
                {
                    Id = 8,
                    ClientId = 9, // Pedro
                    Title = "Programar aplicación web",
                    Status = JobStatusEnum.Available,
                    Description = "Necesito un desarrollador fullstack para una app de gestión",
                    Category = CategoryEnum.Technology,
                    Province = "Santa Fe",
                    City = "Bigand",
                    DayPublicationStart = new DateTime(2025, 5, 17),
                    DayPublicationEnd = new DateTime(2025, 5, 24),
                    PaymentId = 1
                }
            );


            //// POSTULATIONS (IDs: 1 al 5)
            modelBuilder.Entity<Postulation>().HasData(
                new Postulation
                {
                    Id = 1,
                    ClientId = 6, // Mario
                    JobId = 1,
                    Budget = 15000,
                    Status = PostulationStatusEnum.Pending
                },
                new Postulation
                {
                    Id = 2,
                    ClientId = 7, // Depe
                    JobId = 1,
                    Budget = 14000,
                    Status = PostulationStatusEnum.Success
                },
                new Postulation
                {
                    Id = 3,
                    ClientId = 4, // Maximo
                    JobId = 3,
                    Budget = 20000,
                    Status = PostulationStatusEnum.Pending
                },
                new Postulation
                {
                    Id = 4,
                    ClientId = 8, // Pale
                    JobId = 3,
                    Budget = 18000,
                    Status = PostulationStatusEnum.Rejected
                },
                new Postulation
                {
                    Id = 5,
                    ClientId = 9, // Pedro
                    JobId = 4,
                    Budget = 22000,
                    Status = PostulationStatusEnum.Success
                }
            );
        }
    }
}
