using EndavaTechCourse.Bank.Domain.Common;

namespace EndavaTechCourse.Bank.Domain.Models
{
    public class Currency : BaseEntity
    {
        public decimal ChangeRate { get; set; }
        public string CurrencyCode { get; set; }
        public string CurrencyName { get; set; }
        public string CurrencyAbbreviation { get; set; }
    }
}