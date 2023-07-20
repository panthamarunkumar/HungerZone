using HungerZone.Services.CouponAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace HungerZone.Services.CouponAPI.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Coupon> Coupons { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Coupon>().HasData(new Coupon
            {
                CouponId = 1,
                CouponCode = "Test",
                DiscountAmount=899,
                MinAmount=1600
            });
            modelBuilder.Entity<Coupon>().HasData(new Coupon
            {
                CouponId = 2,
                CouponCode = "Test2",
                DiscountAmount = 99,
                MinAmount = 100
            });
            modelBuilder.Entity<Coupon>().HasData(new Coupon
            {
                CouponId = 3,
                CouponCode = "Test3",
                DiscountAmount = 99,
                MinAmount = 600
            });
        }
       

    }
   
}
