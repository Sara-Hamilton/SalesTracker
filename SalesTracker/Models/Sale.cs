using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SalesTracker.Models
{
    [Table("Sales")]
    public class Sale
    {
        [Key]
        public int SaleId { get; set; }
        public virtual ICollection<Item> Items { get; set; }
        public decimal Ammount { get; set; }
        public string UserId { get; set; }
        public virtual ApplicationUser User { get; set; }
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime Date { get; set; }
        public string Comments { get; set; }
        public decimal Commission { get; set; }
        public bool CommissionPaid { get; set; }

        public Sale() { }

        public Sale(List<Item> items, DateTime date, int id = 0)
        {
            Items = items;
            Date = date;
            SaleId = id;
        }

        public override bool Equals(System.Object otherSale)
        {
            if (!(otherSale is Sale))
            {
                return false;
            }
            else
            {
                Sale newSale = (Sale)otherSale;
                return this.SaleId.Equals(newSale.SaleId);
            }
        }

        public override int GetHashCode()
        {
            return this.SaleId.GetHashCode();
        }
    }

}
