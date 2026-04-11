using Client_On_Boarding.Data;
using Client_On_Boarding.DTO;
using Client_On_Boarding.Models;
using Microsoft.EntityFrameworkCore;

namespace Client_On_Boarding.Repositories
{
    public interface IPagesFieldAllowanceRepository : IGenericRepository<Pages>
    {
        Task<int> AddClientPageAllowances(ClientPagesAllowancesVM request);
    }

    public class PagesFieldAllowanceRepository : GenericRepository<Pages>, IPagesFieldAllowanceRepository
    {
        private readonly AppDbContext _context;

        public PagesFieldAllowanceRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<int> AddClientPageAllowances(ClientPagesAllowancesVM request)
        {
            var exsistingAllowances = _context.ClientPageAllowances.Where(c => c.ClientId == request.ClientId).ToList();
            _context.ClientPageAllowances.RemoveRange(exsistingAllowances);

            var newAllowances = request.PageIds.Select(pageId => new ClientPageAllowance
            {
                ClientId = request.ClientId,
                PageId = pageId
            }).ToList();

            await _context.ClientPageAllowances.AddRangeAsync(newAllowances);
            return await _context.SaveChangesAsync();
        }

        public async Task<List<int>> GetAllowedPageIdsByClientAsync(int clientId)
        {
            return await _context.ClientPageAllowances
                .Where(x => x.ClientId == clientId)
                .Select(x => x.PageId)
                .ToListAsync();
        }
    }
}
