namespace Client_On_Boarding.Models
{
    public class BillingCycle : BaseEntity
    {
        public string? BillingName { get; set; }

        public int DiscountPercentage { get; set; }

        public List<ClientLead>? ClientLeads { get; set; }
    }
}
