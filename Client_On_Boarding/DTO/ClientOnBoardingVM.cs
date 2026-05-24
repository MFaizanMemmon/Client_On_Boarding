using Client_On_Boarding.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Client_On_Boarding.DTO
{
    public class ClientOnBoardingVM
    {
        public int? ClientId { get; set; }
        public List<SelectListItem>? ClientLeads { get; set; } = new List<SelectListItem>();

        public ClientLead? ClientLeadDetail { get; set; }

        public List<SubscriptionPlain>? SubscriptionPlain { get; set; }


        public List<BillingCycle>? BillingCycle { get; set; }

        public DateTime SubscriptionStartDate { get; set; }

        public List<ERPModules>? Modules { get; set; }

        public int StatusId { get; set; }

        public List<SelectListItem> StatusDropdown { get; set; } = new List<SelectListItem>();

       

      

    }
}
