using EndavaTechCourse.Bank.Domain.Common;

namespace EndavaTechCourse.Bank.Domain.Models
{
    public class Report : BaseEntity
    {
        public decimal SpentAmount { get; set; }
        public decimal SavingsAccumulated { get; set; }
    }
}