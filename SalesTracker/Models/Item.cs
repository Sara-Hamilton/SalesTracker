using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SalesTracker.Models
{
    [Table("Items")]
    public class Item
    {

        [Key]
        public int ItemId { get; set; }
        public string Name { get; set; }
        public decimal ItemCost { get; set; }
        public decimal ItemPrice { get; set; }
        public int Stock { get; set; }

    }
}
