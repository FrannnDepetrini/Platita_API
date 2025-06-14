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
        public DbSet<OneTimeToken> OneTimeTokens { get; set; }

        // Esto de acá no crea todas estas tablas sino que las hace disponibles para consultas en vez de tener que llamar a la tabla Users
        public DbSet<SysAdmin> SysAdmins { get; set; }
        public DbSet<Moderator> Moderators { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Support> Supports { get; set; }
        public DbSet<Report> Reports { get; set; }



        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }

        //Trabajos para testear db y endpoints de delete/deleteLogic
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<User>().HasIndex(u => u.Email).IsUnique();
            //  acá le digo a la tabla User que va a tener una columna que sirve para discriminar el tipo de User
            modelBuilder.Entity<User>()
                .HasDiscriminator<RolesEnum>("Role")
                .HasValue<SysAdmin>(RolesEnum.SysAdmin)
                .HasValue<Moderator>(RolesEnum.Moderator)
                .HasValue<Client>(RolesEnum.Client)
                .HasValue<Support>(RolesEnum.Support);

            modelBuilder.Entity<Client>()
                .HasMany(c => c.Jobs)
                .WithOne(j => j.Client) 
                .HasForeignKey(j => j.ClientId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Client>()
                .HasMany(c => c.Ratings)
                .WithOne()
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Job>()
                .HasMany(j => j.Postulations)
                .WithOne(p => p.Job)
                .HasForeignKey(p => p.JobId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Job>()
                .HasOne(j => j.Client)
                .WithMany(c => c.Jobs)
                .HasForeignKey(j => j.ClientId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Job>()
                .HasMany(j => j.Postulations)
                .WithOne(p => p.Job)
                .HasForeignKey(p => p.JobId);

            modelBuilder.Entity<Job>()
                 .HasMany(j => j.Reports)
                 .WithOne(j => j.Job)
                 .HasForeignKey(j => j.JobId)
                 .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Job>()
                .HasOne(c => c.PostulationSelected)
                .WithMany()
                .HasForeignKey(c => c.PostulationSelectedId)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Postulation>()
               .HasOne(j => j.Client)
               .WithMany(c => c.Postulations)
               .HasForeignKey(j => j.ClientId)
               .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Rating>()
                .HasOne(r => r.Job)
                .WithMany()
                .HasForeignKey(r => r.JobId);

            modelBuilder.Entity<Complaint>()
                .HasOne(c => c.Client)
                .WithMany()
                .HasForeignKey(c => c.ClientId);


            ////SYSADMIN
            //modelBuilder.Entity<SysAdmin>().HasData(new SysAdmin
            //{
            //    Id = 1,
            //    Email = "sysadmin@gmail.com",
            //    Password = BCrypt.Net.BCrypt.HashPassword("sysadmin"),
            //    UserName = "platita",
            //    PhoneNumber = "341001122",
            //    Role = RolesEnum.SysAdmin
            //});

            ////MODERATOR
            //modelBuilder.Entity<Moderator>().HasData(new Moderator
            //{
            //    Id = 2,
            //    Email = "moderator@gmail.com",
            //    Password = BCrypt.Net.BCrypt.HashPassword("moderator"),
            //    UserName = "moderator1",
            //    PhoneNumber = "341987654321",
            //    Role = RolesEnum.Moderator
            //});


            ////SUPPORT
            //modelBuilder.Entity<Support>().HasData(new Support
            //{
            //    Id = 3,
            //    Email = "support@gmail.com",
            //    Password = BCrypt.Net.BCrypt.HashPassword("support"),
            //    UserName = "support1",
            //    PhoneNumber = "341112233",
            //    Role = RolesEnum.Support
            //});

            ////CLIENTES(IDs: 4 al 10)

            //modelBuilder.Entity<Client>().HasData(new Client
            //{
            //    Id = 4,
            //    Province = "Santa Fe",
            //    City = "Rosario",
            //    Email = "marmax0504@gmail.com",
            //    UserName = "Maximo Martin",
            //    Password = BCrypt.Net.BCrypt.HashPassword("123"),
            //    PhoneNumber = "3496502453",
            //    Role = RolesEnum.Client

            //}, new Client
            //{
            //    Id = 5,
            //    Province = "Buenos Aires",
            //    City = "La Plata",
            //    Email = "joako.tanlon@gmail.com",
            //    UserName = "Joaquin Tanlongo",
            //    Password = BCrypt.Net.BCrypt.HashPassword("456"),
            //    PhoneNumber = "3412122907",
            //    Role = RolesEnum.Client
            //}, new Client
            //{
            //    Id = 6,
            //    Province = "Santa Fe",
            //    City = "Rosario",
            //    Email = "marucomass@gmail.com",
            //    UserName = "Mario Massonnat",
            //    Password = BCrypt.Net.BCrypt.HashPassword("789"),
            //    PhoneNumber = "3467637190",
            //    Role = RolesEnum.Client
            //},
            //    new Client
            //    {
            //        Id = 7,
            //        Province = "Córdoba",
            //        City = "Marcos Juarez",
            //        Email = "frandepe7@gmail.com",
            //        UserName = "Francisco Depetrini",
            //        Password = BCrypt.Net.BCrypt.HashPassword("111"),
            //        PhoneNumber = "3472582334",
            //        Role = RolesEnum.Client
            //    },
            //    new Client
            //    {
            //        Id = 8,
            //        Province = "Santa Fe",
            //        City = "Firmat",
            //        Email = "palenafrancisco@gmail.com",
            //        UserName = "Francisco Palena",
            //        Password = BCrypt.Net.BCrypt.HashPassword("222"),
            //        PhoneNumber = "3465664518",
            //        Role = RolesEnum.Client
            //    },
            //    new Client
            //    {
            //        Id = 9,
            //        Province = "Santa Fe",
            //        City = "Bigand",
            //        Email = "pedrogasparini99@gmail.com",
            //        UserName = "Pedro Gasparini",
            //        Password = BCrypt.Net.BCrypt.HashPassword("333"),
            //        PhoneNumber = "3464445164",
            //        Role = RolesEnum.Client
            //    }
            //);



            //JOBS(IDs: 1 al 4)
            //modelBuilder.Entity<Job>().HasData(
            //    new Job
            //    {
            //        Id = 1,
            //        ClientId = 4, // Maximo
            //        PostulationSelectedId = 2,
            //        Title = "Pintar departamento",
            //        Status = JobStatusEnum.Available,
            //        Description = "Necesito pintar un monoambiente en el centro",
            //        Category = CategoryEnum.Painter,
            //        Province = "Santa Fe",
            //        City = "Rosario",
            //        DayPublicationStart = new DateTime(2025, 5, 15),
            //        DayPublicationEnd = new DateTime(2025, 5, 24),
            //    },
            //    new Job
            //    {
            //        Id = 2,
            //        ClientId = 4, // Maximo,
            //        Title = "Instalación de luces LED",
            //        Status = JobStatusEnum.Available,
            //        Description = "Instalación de 10 luces LED en cocina y living",
            //        Category = CategoryEnum.Electricity,
            //        Province = "Santa Fe",
            //        City = "Rosario",
            //        DayPublicationStart = new DateTime(2025, 5, 13),
            //        DayPublicationEnd = new DateTime(2025, 5, 20),
            //    },
            //    new Job
            //    {
            //        Id = 3,
            //        ClientId = 5, // Joaquin
            //        PostulationSelectedId = 3,
            //        Title = "Corte de pasto y desmalezado",
            //        Status = JobStatusEnum.Available,
            //        Description = "Patio de 100m2 con pasto alto, se necesita corte y limpieza",
            //        Category = CategoryEnum.Gardening,
            //        Province = "Buenos Aires",
            //        City = "La Plata",
            //        DayPublicationStart = new DateTime(2025, 5, 15),
            //        DayPublicationEnd = new DateTime(2025, 5, 18),
            //    },
            //    new Job
            //    {
            //        Id = 4,
            //        ClientId = 6, // Mario
            //        PostulationSelectedId = 5,
            //        Title = "Reparar cañería del baño",
            //        Status = JobStatusEnum.Available,
            //        Description = "Hay una pérdida debajo del lavabo",
            //        Category = CategoryEnum.Plumbing,
            //        Province = "Mendoza",
            //        City = "Godoy Cruz",
            //        DayPublicationStart = new DateTime(2025, 5, 17),
            //        DayPublicationEnd = new DateTime(2025, 5, 23),
            //    },
            //    new Job
            //    {
            //        Id = 5,
            //        ClientId = 6, // Mario
            //        Title = "Mudanza de muebles",
            //        Status = JobStatusEnum.Available,
            //        Description = "Necesito ayuda para mudar muebles pesados",
            //        Category = CategoryEnum.Moving,
            //        Province = "Santa Fe",
            //        City = "Rosario",
            //        DayPublicationStart = new DateTime(2025, 5, 17),
            //        DayPublicationEnd = new DateTime(2025, 5, 22),
            //    },
            //    new Job
            //    {
            //        Id = 6,
            //        ClientId = 7, // Depe
            //        Title = "Corte de césped y limpieza del jardín",
            //        Status = JobStatusEnum.Available,
            //        Description = "Jardín de 50m2 con césped crecido",
            //        Category = CategoryEnum.Gardening,
            //        Province = "Córdoba",
            //        City = "Marcos Juarez",
            //        DayPublicationStart = new DateTime(2025, 5, 16),
            //        DayPublicationEnd = new DateTime(2025, 5, 20),
            //    },
            //    new Job
            //    {
            //        Id = 7,
            //        ClientId = 8, // Pale
            //        Title = "Limpieza de hogar",
            //        Status = JobStatusEnum.Available,
            //        Description = "Limpieza profunda de casa de 3 ambientes",
            //        Category = CategoryEnum.Cleaning,
            //        Province = "Santa Fe",
            //        City = "Firmat",
            //        DayPublicationStart = new DateTime(2025, 4, 21),
            //        DayPublicationEnd = new DateTime(2025, 4, 26),
            //    },
            //    new Job
            //    {
            //        Id = 8,
            //        ClientId = 9, // Pedro
            //        Title = "Programar aplicación web",
            //        Status = JobStatusEnum.Available,
            //        Description = "Necesito un desarrollador fullstack para una app de gestión",
            //        Category = CategoryEnum.Technology,
            //        Province = "Santa Fe",
            //        City = "Bigand",
            //        DayPublicationStart = new DateTime(2025, 5, 17),
            //        DayPublicationEnd = new DateTime(2025, 5, 24),

            //    }
            //);

            ////REPORTS
            //modelBuilder.Entity<Report>().HasData(
            //    new Report
            //    {
            //        Id = 1,
            //        Created_At = new DateTime(2025, 5, 28),
            //        CategoryReport = CategoryReport.OffensiveContent,
            //        JobId = 8,
            //        ClientId = 4,
            //    },
            //    new Report
            //    {
            //        Id = 2,
            //        Created_At = new DateTime(2025, 5, 27),
            //        CategoryReport = CategoryReport.Spam,
            //        JobId = 8,
            //        ClientId = 5,
            //    },
            //    new Report
            //    {
            //        Id = 3,
            //        Created_At = new DateTime(2025, 5, 25),
            //        CategoryReport = CategoryReport.OffensiveContent,
            //        JobId = 7,
            //        ClientId = 6,
            //    }
            //);

            //// POSTULATIONS (IDs: 1 al 5)
            //modelBuilder.Entity<Postulation>().HasData(
            //        new Postulation
            //        {
            //            Id = 1,
            //            ClientId = 6, // Mario
            //            JobId = 1,
            //            Budget = 15000,
            //            JobDay = new DateTime(2025, 5, 23),
            //            Status = PostulationStatusEnum.Pending
            //        },
            //        new Postulation
            //        {
            //            Id = 2,
            //            ClientId = 7, // Depe
            //            JobId = 1,
            //            Budget = 14000,
            //            JobDay = new DateTime(2025, 5, 22),
            //            Status = PostulationStatusEnum.Success
            //        },
            //        new Postulation
            //        {
            //            Id = 3,
            //            ClientId = 4, // Maximo
            //            JobId = 3,
            //            Budget = 20000,
            //            JobDay = new DateTime(2025, 5, 16),
            //            Status = PostulationStatusEnum.Success
            //        },
            //        new Postulation
            //        {
            //            Id = 4,
            //            ClientId = 8, // Pale
            //            JobId = 3,
            //            Budget = 18000,
            //            JobDay = new DateTime(2025, 5, 17),
            //            Status = PostulationStatusEnum.Rejected
            //        },
            //        new Postulation
            //        {
            //            Id = 5,
            //            ClientId = 9, // Pedro
            //            JobId = 4,
            //            Budget = 22000,
            //            JobDay = new DateTime(2025, 5, 21),
            //            Status = PostulationStatusEnum.Success
            //        }
            //    );



            //modelBuilder.Entity<Rating>().HasData(
            //        new Rating
            //        {
            //            Id = 1,
            //            RatedByUserId = 7,
            //            RatedUserId = 4,
            //            Score = 4,
            //            Description = "muy amable y hasta me ofrecio facturas.",
            //            JobId = 1
            //        },
            //        new Rating
            //        {
            //            Id = 2,
            //            RatedByUserId = 4,
            //            RatedUserId = 7,
            //            Score = 5,
            //            Description = "tipazo, muy prolijo!",
            //            JobId = 1
            //        },
            //        new Rating
            //        {
            //            Id = 3,
            //            RatedByUserId = 4,
            //            RatedUserId = 5,
            //            Score = 1,
            //            Description = "estaba de mal humor y me trato bastante mal",
            //            JobId = 3
            //        }, new Rating
            //        {
            //            Id = 4,
            //            RatedByUserId = 5,
            //            RatedUserId = 4,
            //            Score = 1,
            //            Description = "me dejo el patio hecho un desastre",
            //            JobId = 3
            //        }, new Rating
            //        {
            //            Id = 5,
            //            RatedByUserId = 9,
            //            RatedUserId = 6,
            //            Score = 3,
            //            Description = "el baño estaba un poco sucio. buen trato!",
            //            JobId = 4
            //        }
            //   );
        }
    }
}
