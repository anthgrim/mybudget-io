using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace server.Models
{
    public class Expense
    {
        [Key]
        public Guid Id { get; set; }
        public string Title { get; set; }
        public double Amount { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        [DisplayName("Image Url")]
        public string ImageUrl { get; set; }
        [ForeignKey("BudgetId")]
        public Guid? BudgetId { get; set; }
        public virtual Budget Budget { get; set; }
        [ForeignKey("ExpenseCategoryId")]
        public Guid? ExpenseCategoryId { get; set; }
        public virtual ExpenseCategory ExpenseCategory { get; set; }
        [ForeignKey("UserId")]
        public Guid? UserId { get; set; }
        public virtual User User { get; set; }
    }
}
