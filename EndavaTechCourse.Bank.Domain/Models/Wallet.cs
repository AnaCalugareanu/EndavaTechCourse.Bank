using EndavaTechCourse.Bank.Domain.Common;

namespace EndavaTechCourse.Bank.Domain.Models
{
    public class Wallet : BaseEntity
    {
        public decimal Amount { get; set; }
        public string Type { get; set; }
        public Currency Currency { get; set; }
        public decimal Savings { get; set; }
    }
}