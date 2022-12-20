using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace server.Models
{
    public class Budget
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public double Amount { get; set; }
        public bool IsArchived { get; set; }
        [DisplayName("Incomes Collection")]
        public ICollection<Income>? IncomesCollection { get; set; }
        [DisplayName("Expenses Collection")]
        public ICollection<Expense>? ExpensesCollection { get; set; }
        [ForeignKey("UserId")]
        public Guid? UserId { get; set; }
        public virtual User User { get; set; }

    }
}
