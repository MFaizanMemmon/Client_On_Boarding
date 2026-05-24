namespace Client_On_Boarding.Models
{
    public class SubscriptionPlain : BaseEntity
    {
        public string? PlainName { get; set; }

        public decimal? Amount { get; set; }

        public string? ComaSeperated_Description { get; set; }

        public List<ClientLead>? ClientLeads { get; set; }
    }
}
