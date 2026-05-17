using Client_On_Boarding.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Client_On_Boarding.DTO
{
    public class PageFieldAllowanceVM 
    {
        public int? SelectedClientId { get; set; }
        public List<Pages>? Pages { get; set; }
        public List<SelectListItem> ClientDropdown { get; set; } = new List<SelectListItem>();
        public List<int> AllowedPageIds { get; set; } = new List<int>();

        public List<ClientPageAllowance>? PageAllowance { get; set; }
        public List<PagesFieldSettings>? AllowPageFields { get; set; }
    }
}
