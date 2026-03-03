using Lms.Data.Models.Delocal;

namespace Lms.Data
{
    public interface IOperatorRepository
    {
        Task<Operator?> ValidateOperatorAsync(string username, string password);
        Task<Operator?> GetOperatorByNameAsync(string username);
        Task<List<LibLocation>> GetAllowedLocationsAsync(Operator op);
    }
}
