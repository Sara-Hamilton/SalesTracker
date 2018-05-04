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
        public string Itemized { get; set; }
        public decimal Ammount { get; set; }
        public string UserId { get; set; }
        public virtual ApplicationUser User { get; set; }
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime Date { get; set; }
        public string Comments { get; set; }
        public decimal Commission { get; set; }
        public bool CommissionPaid { get; set; }

        public Sale() { }

        public Sale(string items, DateTime date, int id = 0)
        {
            Itemized = items;
            Date = date;
            SaleId = id;
        }

        public Sale(List<dynamic[]> SalesInfo)
        {
            var count = SalesInfo.Count();
            decimal totalProfit = 0m;
            decimal totalAmmount = 0m;
            string itemized = "";
            DateTime date = DateTime.Now; 
            for(int i = 0; i< SalesInfo.Count-1; i++)
            {
                var itemCount = SalesInfo[i][0];
                var itemId = SalesInfo[i][1];
                var itemPrice = SalesInfo[i][2];
                var itemCost = SalesInfo[i][3];
                 totalAmmount += itemCount * itemPrice;
                totalProfit += (itemPrice - itemCost);
                itemized += "Item Id: " + itemId + "Cost/Item : " + itemPrice +"/" + itemCount;
             }
            Itemized = itemized;
            Ammount = totalAmmount;
            Date = date;
            Comments = SalesInfo[count-1][0];
            Commission = totalAmmount * 0.5m;
            CommissionPaid = false;

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
