using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata.Ecma335;

namespace Expense_Tracker.Models
{
    public class Category
    {
        public int Categoryid { get; set; }


        [Column(TypeName = "nvarchar(50)")]
        public required string Title {  get; set; }

        [Column(TypeName ="nvarchar(5)")]
        public required string Icon { get; set; }

        [Column(TypeName = "nvarchar(15)")]
         public required string Type { get; set; }

        //[NotMapped]
        //public string? TitleWithIcon
        //{
        //    get
        //    {
        //        return this.Icon + " " + this.Title;
        //    }
        //}
    }
}
