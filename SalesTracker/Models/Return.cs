using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using SalesTracker.Models;

namespace SalesTracker.Models
{
    [Table("Returns")]
    public class Return
    {
        [Key]
        public int ReturnId { get; set; }
        [ForeignKey ("UserId")]
        public string UserId { get; set; }
        public virtual ApplicationUser User { get; set; }
        [ForeignKey ("SaleId")]
        public int SaleId { get; set; }
        public virtual Sale Sale { get; set; }
        public decimal Ammount { get; set; }
        public List<Item> Items { get; set; }
        public DateTime Date { get; set; }
        public string Comment { get; set; }
        public decimal Commission { get; set; }

    }
}
