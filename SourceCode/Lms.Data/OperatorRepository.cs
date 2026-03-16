using Lms.Data.Models.Delocal;
using Microsoft.EntityFrameworkCore;

namespace Lms.Data
{
    public class OperatorRepository : IOperatorRepository
    {
        private readonly DelocalContext _context;

        public OperatorRepository(DelocalContext context)
        {
            _context = context;
        }

        public async Task<Operator?> ValidateOperatorAsync(string username, string password)
        {
            // Plain-text password comparison as requested
            return await _context.Operators
                .FirstOrDefaultAsync(o => o.OperName == username && o.OperPassword == password);
        }

        public async Task<Operator?> GetOperatorByNameAsync(string username)
        {
            return await _context.Operators
                .FirstOrDefaultAsync(o => o.OperName == username);
        }

        public async Task<List<LibLocation>> GetAllowedLocationsAsync(Operator op)
        {
            // Filter to exclude internal locations as per legacy requirements
            var baseQuery = _context.LibLocations.Where(l => l.LlCode != "WEB" && l.LlCode != "ILL");

            // Scenario A: Super-User Access (sees everything)
            if (op.AccessAllGroups == "Y")
            {
                return await baseQuery.OrderBy(l => l.LlName).ToListAsync();
            }

            // Scenario B: Restricted Access (based on Library Groups)
            var allowedGroupIds = await GetAllowedGroupsAsync(op);

            // Return locations belonging to those groups
            return await baseQuery
                .Where(l => allowedGroupIds.Contains(l.LlGroup))
                .OrderBy(l => l.LlName)
                .ToListAsync();
        }

        public async Task<List<string>> GetAllowedGroupsAsync(Operator op)
        {
            if (op.AccessAllGroups == "Y")
            {
                // Return all distinct groups
                return await _context.LibGroups
                    .Select(g => g.LgGroup)
                    .Distinct()
                    .ToListAsync();
            }

            var primaryLocation = await _context.LibLocations
                .FirstOrDefaultAsync(l => l.LlCode == op.OperLlCode);

            if (primaryLocation == null) return new List<string>();

            var primaryGroup = primaryLocation.LlGroup;
            var permittedGroups = await _context.LibGroupPermits
                .Where(p => p.LgpGivefromGroup == primaryGroup)
                .Select(p => p.LgpGivetoGroup)
                .ToListAsync();

            var allowedGroups = new List<string>();
            if (!string.IsNullOrEmpty(primaryGroup)) allowedGroups.Add(primaryGroup);
            allowedGroups.AddRange(permittedGroups.Where(g => !string.IsNullOrEmpty(g)).Cast<string>());

            return allowedGroups.Distinct().ToList();
        }
    }
}
