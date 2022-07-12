using Arthes_2022.Data.Interfaces;
using Arthes_2022.Models.Entities;
using Microsoft.EntityFrameworkCore;
using AutoMapper;

namespace Arthes_2022.Data.Repositories
{
    public class RevistaRepository : IRevistaRepository
    {
        private readonly ArthesContext _context;
        private readonly IMapper _mapper;
        public RevistaRepository(IMapper mapper, ArthesContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        public async Task<Revista> DetailsRevistas(int id) => 
            await _context.REVISTA.FirstOrDefaultAsync(r => r.Id == id);


        public async Task<IEnumerable<Revista>> GetRevistasToList() => 
            await _context.REVISTA.ToListAsync();
        


    }
}
