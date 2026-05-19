using FinalExam.Models;
using Microsoft.EntityFrameworkCore;

namespace FinalExam.Data
{
    public class AppDbContext:DbContext
    {
        public DbSet<Team> Teams { get; set; }
        public AppDbContext (DbContextOptions<AppDbContext> options) : base(options) { }
    }
}
