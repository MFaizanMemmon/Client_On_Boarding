using Client_On_Boarding.Data;
using Client_On_Boarding.Models;

namespace Client_On_Boarding.Repositories
{
    public interface IPagesFieldAllowanceRepository : IGenericRepository<Pages>
    {

    }

    public class PagesFieldAllowanceRepository : GenericRepository<Pages>, IPagesFieldAllowanceRepository
    {
        private readonly AppDbContext _context;

        public PagesFieldAllowanceRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
