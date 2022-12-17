using Deloitte.Portal.Model;
using Deloitte.Portal.Model.ClaimForms;
using Deloitte.Portal.Model.Test;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;

namespace Deloitte.Portal.DataAccess
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<ClaimFormsModel> Claims { get; set; }
        public DbSet<ReserveFormModel> Reserve { get; set; }
        public DbSet<ClaimReserveForm> ClaimReserve { get; set; }
        public DbSet<File> Files  { get; set; }
        public DbSet<ClaimFile> ClaimFiles { get; set; }
        public DbSet<SpecifiedInjuries> SpecifiedInjuries { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            base.OnModelCreating(builder);
            //builder.Entity<ClaimFormsModel>()
            //    .Property(x => x.claimID).UseIdentityColumn(10000, 1);
        }
    }
}
