using Client_On_Boarding.DTO;
using Client_On_Boarding.Models;
using Client_On_Boarding.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Client_On_Boarding.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IClientLeadRepository _ClientLeadRepository;
        public HomeController(ILogger<HomeController> logger, IClientLeadRepository clientLeadRepository)
        {
            _logger = logger;
            _ClientLeadRepository = clientLeadRepository;
        }

        public async Task<IActionResult> Index()
        {
            DashboardVM dashboardVM = new DashboardVM();

            var clientLeads = await _ClientLeadRepository.GetAllAsync();

            var now = DateTime.Now;

            var currentMonthStart = new DateTime(now.Year, now.Month, 1);
            var nextMonthStart = currentMonthStart.AddMonths(1);

            var previousMonthStart = currentMonthStart.AddMonths(-1);
            var previousMonthEnd = currentMonthStart;

            dashboardVM.TotalClientLead = clientLeads.Count();

            int currentMonthCount = clientLeads.Count(x =>
                x.CreateDate.HasValue &&
                x.CreateDate.Value >= currentMonthStart &&
                x.CreateDate.Value < nextMonthStart
            );

            int previousMonthCount = clientLeads.Count(x =>
                x.CreateDate.HasValue &&
                x.CreateDate.Value >= previousMonthStart &&
                x.CreateDate.Value < previousMonthEnd
            );

            dashboardVM.GrossMonthlyPercent = previousMonthCount == 0
                ? (currentMonthCount > 0 ? 100 : 0)
                : (int)Math.Round(((decimal)(currentMonthCount - previousMonthCount) / previousMonthCount) * 100);

            dashboardVM.ActiveOnBoarding = clientLeads.Where(x => x.LeadStatusID == 4).Count();
            dashboardVM.Followup = clientLeads.Where(x => x.LeadStatusID == 3).Count();

            var LeadStatus = await _ClientLeadRepository.GetLeadStatusesAsync();

            dashboardVM.BusinessType = LeadStatus.Count();

            dashboardVM.Top1BusinessTypeName = clientLeads
                .GroupBy(x => x.IndustryId)
                .OrderByDescending(g => g.Count())
                .Select(g => g.FirstOrDefault().Industry?.IndustryName)
                .FirstOrDefault() ?? "N/A";


            return View(dashboardVM);
        }

        public IActionResult UserProfile()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
