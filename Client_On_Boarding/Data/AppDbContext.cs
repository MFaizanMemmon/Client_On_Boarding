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
        public DbSet<Pages> Pages { get; set; }
        public DbSet<PagesFieldSettings> PageFieldSetting { get; set; }

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

            // Client
            modelBuilder.Entity<ClientLead>().HasData(
                new ClientLead
                {
                    Id = 1,
                    CompanyName = "Software Company",
                    City = "Hyderabad",
                    ClientName = "By Default",
                    CountryId = 3,
                    IndustryId = 3,
                    LeadSourceID = 3,
                    LeadStatusID = 4,
                    Notes = "",
                    CreateDate = DateTime.Now,
                    PhotoPath = "",
                    PostalCode = "",
                    PriorityId = 2,
                    Province = "",
                    StreetAddress = "",
                    PhoneNo = ""
                }

            );

            // Pages

            modelBuilder.Entity<Pages>().HasData(
                new Pages { Id = 1, PageName = "Products" },
                new Pages { Id = 2, PageName = "Customers" },
                new Pages { Id = 3, PageName = "Vendors" },
                new Pages { Id = 4, PageName = "Bank Accounts" },
                new Pages { Id = 5, PageName = "Opening Cash" },
                new Pages { Id = 6, PageName = "General Journal Voucher" },
                new Pages { Id = 7, PageName = "Master Configuration" },
                new Pages { Id = 8, PageName = "Orders" },
                new Pages { Id = 9, PageName = "Invoices" },
                new Pages { Id = 10, PageName = "Receipt" },
                new Pages { Id = 11, PageName = "Sale Return" },
                new Pages { Id = 12, PageName = "Purchase Invoices" },
                new Pages { Id = 13, PageName = "Payment" },
                new Pages { Id = 14, PageName = "Purchase Return" },
                new Pages { Id = 15, PageName = "Cash Billing" },
                new Pages { Id = 16, PageName = "Counter Sale Return" },
                new Pages { Id = 17, PageName = "Expenses" },
                new Pages { Id = 18, PageName = "Stock Adjustment" },
                new Pages { Id = 19, PageName = "Rollback" },
                new Pages { Id = 20, PageName = "Customer Balance" },
                new Pages { Id = 21, PageName = "Vendor Balance" },
                new Pages { Id = 22, PageName = "Bank Balance" },
                new Pages { Id = 23, PageName = "Stock Report" },
                new Pages { Id = 24, PageName = "Customer Ledger" },
                new Pages { Id = 25, PageName = "Vendor Ledger" },
                new Pages { Id = 26, PageName = "Bank/Cash Ledger" },
                new Pages { Id = 27, PageName = "Expenses Reports" },
                new Pages { Id = 28, PageName = "Overall Daily Report" }
                
            );

            // Page Field Settings
            modelBuilder.Entity<PagesFieldSettings>().HasData(
                new PagesFieldSettings { Id = 1, PageId = 1, FieldName = "Product Name", IsView = true ,IsRequired = true },
                new PagesFieldSettings { Id = 2, PageId = 1, FieldName = "Company", IsView = true,IsRequired = false },
                new PagesFieldSettings { Id = 3, PageId = 1, FieldName = "Category", IsView = true ,IsRequired = true },
                new PagesFieldSettings { Id = 4, PageId = 1, FieldName = "Main Unit", IsView = true, IsRequired = true },
                new PagesFieldSettings { Id = 5, PageId = 1, FieldName = "Has Alternate Unit?", IsView = true, IsRequired = false },
                new PagesFieldSettings { Id = 6, PageId = 1, FieldName = "Purchase Rate", IsView = true, IsRequired = false },
                new PagesFieldSettings { Id = 7, PageId = 1, FieldName = "Sales Rate", IsView = true, IsRequired = false },
                new PagesFieldSettings { Id = 8, PageId = 1, FieldName = "Opening Stock", IsView = true, IsRequired = false },
                new PagesFieldSettings { Id = 9, PageId = 1, FieldName = "Active", IsView = true, IsRequired = false },
                new PagesFieldSettings { Id = 10, PageId = 2, FieldName = "Customer Name", IsView = true, IsRequired = true },
                new PagesFieldSettings { Id = 11, PageId = 2, FieldName = "City", IsView = true, IsRequired = false },
                new PagesFieldSettings { Id = 12, PageId = 2, FieldName = "Area By City", IsView = true, IsRequired = false },
                new PagesFieldSettings { Id = 13, PageId = 2, FieldName = "Full Address", IsView = true, IsRequired = false },
                new PagesFieldSettings { Id = 14, PageId = 2, FieldName = "Office Phone", IsView = true, IsRequired = false },
                new PagesFieldSettings { Id = 15, PageId = 2, FieldName = "Contact No 1", IsView = true, IsRequired = false },
                new PagesFieldSettings { Id = 16, PageId = 2, FieldName = "Contact No 2", IsView = true, IsRequired = false },
                new PagesFieldSettings { Id = 17, PageId = 2, FieldName = "Opening Balance", IsView = true, IsRequired = false },
                new PagesFieldSettings { Id = 18, PageId = 2, FieldName = "Active", IsView = true, IsRequired = false },
                new PagesFieldSettings { Id = 19, PageId = 3, FieldName = "Vendor Name", IsView = true, IsRequired = true },
                new PagesFieldSettings { Id = 20, PageId = 3, FieldName = "City", IsView = true, IsRequired = false },
                new PagesFieldSettings { Id = 21, PageId = 3, FieldName = "Area By City", IsView = true, IsRequired = false },
                new PagesFieldSettings { Id = 22, PageId = 3, FieldName = "Full Address", IsView = true, IsRequired = false},
                new PagesFieldSettings { Id = 23 , PageId = 3, FieldName = "Office Phone",IsView = true, IsRequired = false},
                new PagesFieldSettings { Id = 24 , PageId = 3, FieldName = "Contact No 1", IsView = true, IsRequired = false},
                new PagesFieldSettings { Id = 25, PageId = 3, FieldName = "Contact No 2", IsView = true, IsRequired = false},
                new PagesFieldSettings { Id = 26, PageId = 3, FieldName = "Opening Balance", IsView = true , IsRequired = false},
                new PagesFieldSettings { Id = 27, PageId = 3,FieldName = "Active", IsView = true , IsRequired = false},
                new PagesFieldSettings { Id = 28, PageId = 4, FieldName = "Bank Name", IsView = true, IsRequired = true },
                new PagesFieldSettings { Id = 29, PageId = 4, FieldName = "Account Holder",IsView = true , IsRequired = false},
                new PagesFieldSettings { Id = 30, PageId = 4 ,FieldName = "Account No", IsView = true, IsRequired = false},
                new PagesFieldSettings { Id = 31, PageId = 4, FieldName = "Address", IsView = true,IsRequired = false},
                new PagesFieldSettings { Id = 32, PageId = 4 , FieldName = "Opening Balance", IsView = true,IsRequired = false},
                new PagesFieldSettings { Id = 33, PageId = 4, FieldName = "Active", IsView = true, IsRequired = false }
            );



        }
    }
}
