using Client_On_Boarding.DTO;
using Client_On_Boarding.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Client_On_Boarding.Controllers
{
    public class ERPSettingsController : Controller
    {
        private readonly IClientLeadRepository _clientLeadRepository;
        private readonly IPagesFieldAllowanceRepository _pagesFieldAllowanceRepository;
        public ERPSettingsController(IClientLeadRepository clientLeadRepository, IPagesFieldAllowanceRepository pagesFieldAllowanceRepository)
        {
            _clientLeadRepository = clientLeadRepository;
            _pagesFieldAllowanceRepository = pagesFieldAllowanceRepository;
        }

        public async Task<IActionResult> PageAllowance(int? clientId)
        {
            PageFieldAllowanceVM vm = new PageFieldAllowanceVM();

            var clients = await _clientLeadRepository.GetAllAsync();

            vm.ClientDropdown = clients.Select(c => new SelectListItem
            {
                Value = c.Id.ToString(),
                Text = c.ClientName
            }).ToList();

            vm.Pages = (await _pagesFieldAllowanceRepository.GetAllAsync()).ToList();
            vm.SelectedClientId = clientId;

            
            return View(vm);
        }
        public IActionResult PageFieldAllowance()
        {
            return View();
        }

        public IActionResult ClientERPSettings()
        {
            return View();
        }
    }
}
