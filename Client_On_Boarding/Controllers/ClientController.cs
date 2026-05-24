using Client_On_Boarding.DTO;
using Client_On_Boarding.Models;
using Client_On_Boarding.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Client_On_Boarding.Controllers
{
    public class ClientController : Controller
    {
        private readonly IClientLeadRepository _ClientLeadrepo;

        public ClientController(IClientLeadRepository ClientLeadrepo)
        {
            _ClientLeadrepo = ClientLeadrepo;
        }

        public async Task<IActionResult> ClientLeads()
        {
            ClientLeadVM vm = new ClientLeadVM();

            vm.ClientLeads = (await _ClientLeadrepo.GetAllWithRelationsAsync())
                .Where(x => x.LeadStatusID == 1)
                .ToList();

            var statuses = await _ClientLeadrepo.GetLeadStatusesAsync();
            var sources = await _ClientLeadrepo.GetLeadSourcesAsync();

            vm.StatusDropdown = statuses.Select(x => new SelectListItem
            {
                Text = x.StatusName,
                Value = x.Id.ToString()
            });

            vm.LeadSourceDropdown = sources.Select(x => new SelectListItem
            {
                Text = x.LeadSourceName,
                Value = x.Id.ToString()
            });

            return View(vm);
        }

        public async Task<IActionResult> CreateClientLead()
        {
            var model = new ClientLeadVM
            {
                ClientLead = new ClientLead()
            };

            await PopulateDropdownsAsync(model);

            return View(model);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateClientLead(ClientLeadVM model, IFormFile Photo)
        {
            if (Photo != null && Photo.Length > 0)
            {
                var uploadsFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads");

                // ✅ Create folder if not exists
                if (!Directory.Exists(uploadsFolder))
                {
                    Directory.CreateDirectory(uploadsFolder);
                }

                var fileName = Guid.NewGuid().ToString() + Path.GetExtension(Photo.FileName);
                var filePath = Path.Combine(uploadsFolder, fileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await Photo.CopyToAsync(stream);
                }

                model.ClientLead.PhotoPath = fileName;
            }

            await _ClientLeadrepo.AddAsync(model.ClientLead);
            await _ClientLeadrepo.SaveAsync();

            return RedirectToAction("ClientLeads");
        }

        public async Task<IActionResult> ClientOnboarding()
        {
            ClientLeadVM vm = new ClientLeadVM();

            var clientLeads = await _ClientLeadrepo.GetAllWithRelationsAsync();

            vm.ClientLeads = clientLeads
                .Where(x => x.LeadStatusID != 1)
                .ToList();

            return View(vm);
        }

        [HttpGet]
        public async Task<IActionResult> CreateOnboarding(int? clientId)
        {
            var model = new ClientOnBoardingVM();

            await LoadCreateOnboardingDropdowns(model);

            if (clientId.HasValue)
            {
                model.ClientId = clientId.Value;
                model.ClientLeadDetail = await _ClientLeadrepo.GetByIdWithRelationsAsync(clientId.Value);
            }

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateOnboarding(ClientOnBoardingVM model)
        {
            if (!ModelState.IsValid)
            {
                await LoadCreateOnboardingDropdowns(model);

                if (model.ClientId > 0)
                {
                    model.ClientLeadDetail = await _ClientLeadrepo.GetByIdWithRelationsAsync(Convert.ToInt32(model.ClientId));
                }

                return View(model);
            }

            var clientLead = await _ClientLeadrepo.GetByIdAsync(Convert.ToInt32(model.ClientId));

            if (clientLead == null)
            {
                return NotFound();
            }

            clientLead.InternalNotes = model.ClientLeadDetail.InternalNotes;
            clientLead.LeadStatusID = model.StatusId;
            clientLead.UserName = model.ClientLeadDetail.UserName;
            clientLead.Password = model.ClientLeadDetail.Password;

            await _ClientLeadrepo.SaveAsync();

            return RedirectToAction("ClientOnboarding", "Client");
        }



        // ── Helpers ────────────────────────────────────────────────────
        private async Task PopulateDropdownsAsync(ClientLeadVM model)
        {
            var industries = await _ClientLeadrepo.GetIndustriesAsync();
            var countries = await _ClientLeadrepo.GetCountriesAsync();
            var leadSources = await _ClientLeadrepo.GetLeadSourcesAsync();
            var statuses = await _ClientLeadrepo.GetLeadStatusesAsync();
            var clientPriority = await _ClientLeadrepo.GetLeadPrioritiesAsync();

            model.IndustryDropdown = industries.Select(x => new SelectListItem
            {
                Value = x.Id.ToString(),
                Text = x.IndustryName
            });

            model.CountriesDropdown = countries.Select(x => new SelectListItem
            {
                Value = x.Id.ToString(),
                Text = x.CountryName
            });

            model.LeadSourceDropdown = leadSources.Select(x => new SelectListItem
            {
                Value = x.Id.ToString(),
                Text = x.LeadSourceName
            });

            model.StatusDropdown = statuses.Select(x => new SelectListItem
            {
                Value = x.Id.ToString(),
                Text = x.StatusName
            });

            model.PriorityDropdown = clientPriority.Select(x => new SelectListItem
            {
                Value = x.Id.ToString(),
                Text = x.PriorityName
            });
        }

        private async Task LoadCreateOnboardingDropdowns(ClientOnBoardingVM model)
        {
            var clientLeads = await _ClientLeadrepo.GetAllAsync();
            var statuses = await _ClientLeadrepo.GetLeadStatusesAsync();

            model.ClientLeads = clientLeads
                .Where(x => x.LeadStatusID == 1)
                .Select(x => new SelectListItem
                {
                    Text = x.CompanyName,
                    Value = x.Id.ToString()
                })
                .ToList();

            model.StatusDropdown = statuses
                .Where(x => x.Id != 1)
                .Select(x => new SelectListItem
                {
                    Value = x.Id.ToString(),
                    Text = x.StatusName
                })
                .ToList();
        }

    }
}
