using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Microsoft.AspNetCore.Mvc.Rendering;

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

        [NotMapped]
        public List<SelectListItem> Categories { get; } = new List<SelectListItem>
        {
            new SelectListItem { Value = "Housing", Text = "Housing" },
            new SelectListItem { Value = "Food", Text = "Food" },
            new SelectListItem { Value = "Debt", Text = "Debt"  },
            new SelectListItem { Value = "Transport", Text = "Transport"  },
            new SelectListItem { Value = "Pets", Text = "Pets"  },
            new SelectListItem { Value = "Utilities", Text = "Utilities"  },
            new SelectListItem { Value = "Subscriptions", Text = "Subscriptions"  },
            new SelectListItem { Value = "Healthcare", Text = "Healthcare"  },
            new SelectListItem { Value = "Home", Text = "Home"  },
            new SelectListItem { Value = "Other", Text = "Other"  },
        };
    }
}
