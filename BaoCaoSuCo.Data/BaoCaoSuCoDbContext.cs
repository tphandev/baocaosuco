using BaoCaoSuCo.Model.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaoCaoSuCo.Data
{
    public class BaoCaoSuCoDbContext : IdentityDbContext<ApplicationUser>
    {
        public BaoCaoSuCoDbContext() : base("BaoCaoSuCoConnection")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }
        public DbSet<SuCo> SuCos { get; set; }
        public DbSet<DonVi> Donvis { get; set; }
        public DbSet<Error> Errors { get; set; }

        public static BaoCaoSuCoDbContext Create()
        {
            return new BaoCaoSuCoDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityUserRole>().HasKey(i => new { i.UserId, i.RoleId });
            modelBuilder.Entity<IdentityUserLogin>().HasKey(i => i.UserId);
          
        }
    }
}
