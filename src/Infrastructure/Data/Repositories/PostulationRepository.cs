﻿using Application.Models.Responses;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Repositories
{
    public class PostulationRepository : BaseRepository<Postulation>, IPostulationRepository
    {
        private new readonly ApplicationContext _context;
        public PostulationRepository(ApplicationContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Postulation?> GetByIdForPublisherAsync(int id)
        {
            return await _context.Postulations
                .Include(p => p.Client)
                .FirstOrDefaultAsync(p => p.Id == id);
        }  

        public async Task<Postulation?> GetByIdForApplicantAsync(int id)
        {
            return await _context.Postulations
                .Include(p => p.Job)
                .FirstOrDefaultAsync(p => p.Id == id);
        }   

        public override async Task<Postulation?> GetById(int id)
        {
            return await _context.Postulations
                .Include(p => p.Job)
                    .ThenInclude(p => p.PostulationSelected)
                    .ThenInclude(c => c.Client)
                .Include(c => c.Job)
                    .ThenInclude(c => c.Client)
                .FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<IEnumerable<Postulation>> GetByJobIdAsync(int jobId)
        {
            return await _context.Postulations
                .Include(p => p.Client)
                .Include(p => p.Job)
                .Where(p => p.JobId == jobId)
                .ToListAsync();
        }

        public Task<IEnumerable<Postulation>> GetByUserIdAsync(int userId)
        {
            throw new NotImplementedException();
        }

        public async Task<Postulation> GetPostulationByJobAndPostulantId(int jobId, int postulantId) 
        {
            return await _context.Postulations
                .Include(p => p.Client)
                .Include(p => p.Job)
                .FirstOrDefaultAsync(p => p.JobId == jobId && p.Id == postulantId);
        }


        public async Task<bool> CheckDuplicatePostulation(int clientId, int jobId)
        {
            return await _context.Postulations
            .AnyAsync(a => a.ClientId == clientId && a.JobId == jobId);
        }

        public async Task<IEnumerable<Postulation>> GetAllMyPostulations(int userId)
        {
            return await _context.Postulations
                .Where(p=>p.ClientId == userId )
                .Include(p=>p.Job)
                .ThenInclude(p=> p.Client)
                .ToListAsync();

        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
