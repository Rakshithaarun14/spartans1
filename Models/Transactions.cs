using System.ComponentModel.DataAnnotations.Schema;

namespace Expense_Tracker.Models
{
    public class Transactions
    { 
        public int TransactionId { get; set; }

        //public int Categoryid { get; set; }
        //public Category Categoryid { get; set; }

        public int Amt { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public required string Note { get; set; }

        public DateTime Date { get; set; } = DateTime.Now;
    }
}

