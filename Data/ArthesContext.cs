using Arthes_2022.Models.Entities;

using Microsoft.EntityFrameworkCore;

namespace Arthes_2022.Data
{
    public class ArthesContext : DbContext
    {
        public ArthesContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Revista> REVISTA { get; set; }
    }
}
