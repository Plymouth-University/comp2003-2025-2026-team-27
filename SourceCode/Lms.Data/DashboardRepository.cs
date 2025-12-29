using Lms.Data.Models.Delib;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Data
{
    public class DashboardRepository : IDashboardRepository
    {
        private readonly DelibContext _context;

        public DashboardRepository(DelibContext context)
        {
            _context = context;
        }

        public async Task<int> GetTotalBookCountAsync()
        {
            // Assuming 'StkItem' table represents books or library items
            // This is a placeholder; actual logic might involve filtering by item type or status
            return await _context.StkItems.CountAsync();
        }

        public async Task<int> GetTotalMemberCountAsync()
        {
            // Assuming 'Borrower' table represents library members
            return await _context.Borrowers.CountAsync();
        }
    }
}
