using System.ComponentModel.DataAnnotations.Schema;

namespace HandsOnAPIWIthEF.Entities
{
    public class Transaction
    {
        public Guid TransactionId { get; set; }= Guid.NewGuid();
        public DateTime TransactionDate { get; set; }
        public Guid OrderId { get; set; }
        public string UserId { get; set; }
        public double Amount { get; set; }
        public string TransactionType { get; set; }
        [ForeignKey("OrderId")]
        public Order Order { get; set; } //navtiagation props
        [ForeignKey("UserId")]
        public User User { get; set; } //navigation props
    }
}
