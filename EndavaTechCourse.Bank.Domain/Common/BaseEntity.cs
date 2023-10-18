namespace EndavaTechCourse.Bank.Domain.Common
{
    public class BaseEntity
    {
        public Guid Id { get; } = Guid.NewGuid();
        public DateTime TimeStamp { get; set; } = DateTime.Now;
    }
}