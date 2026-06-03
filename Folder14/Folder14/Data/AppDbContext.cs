using Folder14.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Folder14.Data
{
    public class AppDbContext:IdentityDbContext<AppUser>
    {
       public  DbSet<Chef> Chefs { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    }
}
