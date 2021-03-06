﻿using System;
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
        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = true)]
        public decimal? ItemCost { get; set; }
        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = true)]
        public decimal? ItemPrice { get; set; }
        public int Stock { get; set; }

        public override bool Equals(System.Object otherItem)
        {
            if (!(otherItem is Item))
            {
                return false;
            }
            else
            {
                Item newItem = (Item)otherItem;
                return this.ItemId.Equals(newItem.ItemId);
            }
        }

        public override int GetHashCode()
        {
            return this.ItemId.GetHashCode();
        }

        public List<dynamic[]> SalesInfo(List<string> count, List<string> id, List<string> price, List<string> cost, string[] comment)
        {
            var Arrays = new List<dynamic[]> { };
            for(int i = 0; i< count.Count(); i++)
            {
                if(count[i] != "")
                {
                    var Viewme = Int32.Parse(id[i]);
                    var newArray = new dynamic [] { Int32.Parse(count[i]), Int32.Parse(id[i]), decimal.Parse(price[i]), decimal.Parse(cost[i])};
                    Arrays.Add(newArray);
                }
            }
                Arrays.Add(comment);
            return Arrays;
        }



    }

}
