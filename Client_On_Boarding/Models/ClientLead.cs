namespace Client_On_Boarding.Models
{
    public class ClientLead : BaseEntity
    {
        public string ClientName { get; set; } = string.Empty;
        public string? PhoneNo { get; set; }
        public string CompanyName { get; set; } = string.Empty;

        // ✅ Industry (One-to-One / Many-to-One)
        public int IndustryId { get; set; }
        public  BusinessIndustry? Industry { get; set; }

        public string? StreetAddress { get; set; }
        public string? City { get; set; }
        public string? Province { get; set; }
        public string? PostalCode { get; set; }

        // ✅ Country
        public int CountryId { get; set; }
        public Country? Country { get; set; }

        // ✅ Lead Source
        public int LeadSourceID { get; set; }
        public LeadSource? LeadSource { get; set; }

        // ✅ Lead Status
        public int LeadStatusID { get; set; }
        public LeadStatus? LeadStatus { get; set; }

        public int? PriorityId { get; set; }
        public LeadPriority? Priority { get; set; }

        public string? Notes { get; set; }

        public string? PhotoPath { get; set; }
    }
}
