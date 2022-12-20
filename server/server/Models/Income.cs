using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace server.Models
{
    public class Income
    {
        [Key]
        public Guid Id { get; set; }
        public string Title { get; set; }
        public double Amount { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        [DisplayName("Image Url")]
        public string? ImageUrl { get; set; }
        [ForeignKey("BudgetId")]
        public Guid? BudgetId { get; set; }
        public virtual Budget Budget { get; set; }
        [ForeignKey("IncomeCategoryId")]
        public Guid? IncomeCategoryId { get; set; }
        public virtual IncomeCategory IncomeCategory { get; set; }
        [ForeignKey("UserId")]
        public Guid? UserId { get; set; }
        public virtual User User { get; set; }
    }
}
