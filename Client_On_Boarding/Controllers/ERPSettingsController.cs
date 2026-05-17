using Client_On_Boarding.DTO;
using Client_On_Boarding.Models;
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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SaveAllowances(ClientPagesAllowancesVM request)
        {
            if (request.ClientId == 0)
            {
                TempData["Error"] = "Please select a client.";
                return RedirectToAction("PageAllowance");
            }

            request.PageIds ??= new List<int>();

            await _pagesFieldAllowanceRepository.AddClientPageAllowances(request);

            TempData["Success"] = $"Saved {request.PageIds.Count} page allowances successfully.";
            return RedirectToAction("PageAllowance", new { clientId = request.ClientId });
        }


        public async Task<IActionResult> PageFieldAllowance(int? ClientId)
        {
            PageFieldAllowanceVM vm = new PageFieldAllowanceVM();

            var clients = await _clientLeadRepository.GetAllAsync();

            vm.ClientDropdown = clients.Select(c => new SelectListItem
            {
                Value = c.Id.ToString(),
                Text = c.ClientName
            }).ToList();

            if (clients != null)
            {
                vm.SelectedClientId = ClientId;
            
              

            }


            return View(vm);
        }

        public IActionResult ClientERPSettings()
        {
            return View();
        }
    }
}
