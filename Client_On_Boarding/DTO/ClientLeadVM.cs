using Client_On_Boarding.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Client_On_Boarding.DTO
{
    public class ClientLeadVM
    {
        public ClientLead ClientLead { get; set; } = new();

        public List<ClientLead>? ClientLeads { get; set; }


        public IEnumerable<SelectListItem> IndustryDropdown { get; set; } = new List<SelectListItem>();
       
        public IEnumerable<SelectListItem> CountriesDropdown { get; set; } = new List<SelectListItem>();

        public IEnumerable<SelectListItem> LeadSourceDropdown { get; set; } = new List<SelectListItem>();

        public IEnumerable<SelectListItem> StatusDropdown { get; set; } = new List<SelectListItem>();

        public IEnumerable<SelectListItem> PriorityDropdown { get; set; } = new List<SelectListItem>();

        public IEnumerable<SelectListItem> ClientDropdown { get; set;  } = new List<SelectListItem>();

    }
}
