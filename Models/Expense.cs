using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Expenses.Models
{
    public class Expense
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int ExpenseID { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Expense Name")]
        public string ExpenseName { get; set; }

        [Required]
        [DisplayName("Amount")]
        public int ExpenseAmount { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        [DisplayName("Category")]
        public string ExpenseCategory { get; set; }

        [Required]
        [DisplayFormat(DataFormatString ="{0:dd-MMM-yyyy}")]
        public DateTime ExpenseDate { get; set; }
    }
}
