using EndavaTechCourse.Bank.Domain.Common;

namespace EndavaTechCourse.Bank.Domain.Models
{
    public class Transaction : BaseEntity
    {
        public decimal Amount { get; set; }
        public Guid WalletId { get; set; }
        public DateTime TransactionDateTime { get; set; } = DateTime.Now;
    }
}