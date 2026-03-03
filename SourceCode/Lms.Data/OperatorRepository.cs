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
            // 1. Get Primary Group from Operator's Default Location
            var primaryLocation = await _context.LibLocations
                .FirstOrDefaultAsync(l => l.LlCode == op.OperLlCode);

            if (primaryLocation == null)
            {
                // Fallback: if no default location, no access to anything
                return new List<LibLocation>();
            }

            var primaryGroup = primaryLocation.LlGroup;

            // 2. Find Related Groups (from LIB_GROUP_PERMITS)
            // Legacy logic: LgpGivefromGroup -> LgpGivetoGroup
            var permittedGroups = await _context.LibGroupPermits
                .Where(p => p.LgpGivefromGroup == primaryGroup)
                .Select(p => p.LgpGivetoGroup)
                .ToListAsync();

            // 3. Combine Primary Group and Related Groups
            var allowedGroupIds = new List<string?> { primaryGroup };
            allowedGroupIds.AddRange(permittedGroups);

            // 4. Return locations belonging to those groups
            return await baseQuery
                .Where(l => allowedGroupIds.Contains(l.LlGroup))
                .OrderBy(l => l.LlName)
                .ToListAsync();
        }
    }
}
