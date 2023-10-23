using EndavaTechCourse.Bank.Domain.Common;

namespace EndavaTechCourse.Bank.Domain.Models
{
    public class CashByCode : BaseEntity
    {
        public decimal Amount { get; set; }
        public string Code { get; set; }
        public Currency CurrencyId { get; set; }
        public Guid WalletId { get; set; }
    }
}