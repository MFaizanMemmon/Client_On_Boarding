using Client_On_Boarding.Models;
using Microsoft.EntityFrameworkCore;

namespace Client_On_Boarding.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> option) : base(option)
        {
        }

        public DbSet<ClientLead> ClientLeads { get; set; }

        public DbSet<BusinessIndustry> BusinessIndustries { get; set; }

        public DbSet<Country> Countries { get; set; }
        public DbSet<LeadSource> LeadSources { get; set; }
        public DbSet<LeadStatus> LeadStatuses { get; set; }

        public DbSet<LeadPriority> LeadPriorities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // ✅ Industry
            modelBuilder.Entity<BusinessIndustry>().HasData(
                new BusinessIndustry { Id = 1, IndustryName = "Rice Wholesaler" },
                new BusinessIndustry { Id = 2, IndustryName = "Medical Wholesaler" },
                new BusinessIndustry { Id = 3, IndustryName = "Electronics" },
                new BusinessIndustry { Id = 4, IndustryName = "Restaurant" }
            );

            modelBuilder.Entity<Country>().HasData(
                new Country { Id = 1, CountryName = "Bangladesh" },
                new Country { Id = 2, CountryName = "India" },
                new Country { Id = 3, CountryName = "Pakistan" },
                new Country { Id = 4, CountryName = "Sri Lanka" }
            );

            // ✅ Lead Sources
            modelBuilder.Entity<LeadSource>().HasData(
                new LeadSource { Id = 1, LeadSourceName = "Referral" },
                new LeadSource { Id = 2, LeadSourceName = "Website" },
                new LeadSource { Id = 3, LeadSourceName = "LinkedIn" },
                new LeadSource { Id = 4, LeadSourceName = "Cold Call" }
            );

            // ✅ Lead Status
            modelBuilder.Entity<LeadStatus>().HasData(
                new LeadStatus { Id = 1, StatusName = "New" },
                new LeadStatus { Id = 2, StatusName = "Contacted" },
                new LeadStatus { Id = 3, StatusName = "Follow-up" },
                new LeadStatus { Id = 4, StatusName = "Active" }
            );

            // Priority
            modelBuilder.Entity<LeadPriority>().HasData(
                new LeadPriority { Id = 1, PriorityName = "Low" },
                new LeadPriority { Id = 2, PriorityName = "Medium" },
                new LeadPriority { Id = 3, PriorityName = "High" }
            );

        }
    }
}
