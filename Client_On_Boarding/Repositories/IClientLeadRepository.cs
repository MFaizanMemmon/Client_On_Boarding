using Client_On_Boarding.Data;
using Client_On_Boarding.Models;
using Microsoft.EntityFrameworkCore;

namespace Client_On_Boarding.Repositories
{
    public interface IClientLeadRepository : IGenericRepository<ClientLead>
    {
        Task<IEnumerable<ClientLead>> GetAllWithRelationsAsync();
        Task<ClientLead?> GetByIdWithRelationsAsync(int id);
        Task<List<BusinessIndustry>> GetIndustriesAsync();
        Task<List<Country>> GetCountriesAsync();
        Task<List<LeadSource>> GetLeadSourcesAsync();
        Task<List<LeadStatus>> GetLeadStatusesAsync();

        Task<List<LeadPriority>> GetLeadPrioritiesAsync();

    }

    public class ClientLeadRepository : GenericRepository<ClientLead>, IClientLeadRepository
    {
        private readonly AppDbContext _context;

        public ClientLeadRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ClientLead>> GetAllWithRelationsAsync()
        {
            return await _context.ClientLeads
                .Include(x => x.Industry)
                .Include(x => x.Country)
                .Include(x => x.LeadSource)
                .Include(x => x.LeadStatus)
                .Include(x => x.Priority)
                .Include(x => x.BillingCycle)
                .Include(x => x.SubscriptionPlain)
                .ToListAsync();
        }

        public async Task<ClientLead?> GetByIdWithRelationsAsync(int id)
        {
            return await _context.ClientLeads
                .Include(x => x.Industry)
                .Include(x => x.Country)
                .Include(x => x.LeadSource)
                .Include(x => x.LeadStatus)
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<Country>> GetCountriesAsync()
        {
            return await _context.Countries.ToListAsync();
        }


        public async Task<List<BusinessIndustry>> GetIndustriesAsync()
        {
            return await _context.BusinessIndustries.ToListAsync();
        }

        public async Task<List<LeadPriority>> GetLeadPrioritiesAsync()
        {
            return await _context.LeadPriorities.ToListAsync();
        }

        public async Task<List<LeadSource>> GetLeadSourcesAsync()
        {
            return await _context.LeadSources.ToListAsync();
        }

        public async Task<List<LeadStatus>> GetLeadStatusesAsync()
        {
            return await _context.LeadStatuses.ToListAsync();
        }
    }
}
