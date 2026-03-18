using Lms.Data.Models.Delib;

namespace Lms.Data
{
    public class BorrowerWithAddress
    {
        public Borrower Borrower { get; set; } = null!;
        public string? FormattedAddress { get; set; }
    }
}
