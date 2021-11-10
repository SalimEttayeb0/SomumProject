using Gestion_Regles_Affaires.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Regles_Affaires.Data.Context
{
    public class ReglesAffairesContext : DbContext
    {
        public ReglesAffairesContext(DbContextOptions options) : base(options)
        {
                
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<ModelBusinessRules>().HasKey(mbr => new { mbr.ModelId, mbr.BusinessRulesId });

            modelBuilder.Entity<ModelBusinessRules>()
                .HasOne(m => m.Model)
                .WithMany(mbr => mbr.ModelBusinessRules)
                .HasForeignKey(mi => mi.ModelId);

            modelBuilder.Entity<ModelBusinessRules>()
                .HasOne(m => m.BusinessRules)
                .WithMany(mbr => mbr.ModelBusinessRules)
                .HasForeignKey(mi => mi.BusinessRulesId);

            // seed BusinessRules data
            modelBuilder.Seed();
        }

        // Models table
        public DbSet<Modele> Models { get; set; }
        public DbSet<BusinessRules> BusinessRules { get; set; }
        public DbSet<ModelBusinessRules> ModelBusinessRules { get; set; }
        public DbSet<ParameterType> ParameterTypes { get; set; }
        public DbSet<Translation> Translations { get; set; }
        public DbSet<BroadcastCampaign> BroadcastCampaigns { get; set; }
        public DbSet<BroadcastCampaignDetails> BroadcastCampaignDetails { get; set; }

    }
}
