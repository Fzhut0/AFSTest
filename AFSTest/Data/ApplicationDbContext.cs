using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AFSTest.Models;
using Microsoft.EntityFrameworkCore;

namespace AFSTest.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<TranslationRecord> TranslationRecords { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}