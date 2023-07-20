
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HungerZone.Services.AuthAPI.Data
{
    public class AppDbcontext:IdentityDbContext<IdentityUser>
    {
        public AppDbcontext(DbContextOptions<AppDbcontext> options):base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //shssu
            //hi a=allS

        }
        }
}
