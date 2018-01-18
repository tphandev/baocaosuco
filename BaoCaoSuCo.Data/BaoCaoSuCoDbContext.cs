using BaoCaoSuCo.Model.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaoCaoSuCo.Data
{
    public class BaoCaoSuCoDbContext:DbContext
    {
        public BaoCaoSuCoDbContext() : base("BaoCaoSuCoConnection")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }
        public DbSet<SuCo> SuCos { get; set; }
        public DbSet<DonVi> Donvis { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
