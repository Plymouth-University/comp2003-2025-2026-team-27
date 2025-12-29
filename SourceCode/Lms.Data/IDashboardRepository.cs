using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lms.Data
{
    public interface IDashboardRepository
    {
        Task<int> GetTotalBookCountAsync();
        Task<int> GetTotalMemberCountAsync();
    }
}
