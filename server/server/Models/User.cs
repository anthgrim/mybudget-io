using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace server.Models
{
    public class User
    {
        [Key]
        public Guid Id { get; set; }
        [DisplayName("First Name")]
        public string FirstName { get; set; } = string.Empty;
        [DisplayName("Last Name")]
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        [DisplayName("Income Categories")]
        public ICollection<IncomeCategory>? IncomeCategories { get; set; }
        [DisplayName("Expense Categories")]
        public ICollection<ExpenseCategory>? ExpenseCategories { get; set; }
        [DisplayName("Incomes Collections")]
        public ICollection<Income>? IncomesCollection { get; set; }
        [DisplayName("Expenses Collection")]
        public ICollection<Expense>? ExpensesCollection { get; set; }
        [DisplayName("Budgets Collection")]
        public ICollection<Budget>? BudgetsCollection { get; set; }
    }
}
