using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace SalesTracker.Models
{
    public class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            if (context.Items.Any())
            {
                return;
            }
        

        var items = new Item[]
        {
            new Item(){ ItemId = 1, Name = "Widget", ItemCost = 2.45m, ItemPrice = 4.28m, Stock = 32},
            new Item(){ ItemId = 2, Name = "DoorWidget", ItemCost = 2.45m, ItemPrice = 4.22m, Stock = 32},
            new Item(){ ItemId = 3, Name = "BeautyWidget", ItemCost = 20.41m, ItemPrice = 120m, Stock = 32},
            new Item(){ ItemId = 4, Name = "HouseWidget", ItemCost = 3.33m, ItemPrice = 25.13m, Stock = 32},
            new Item(){ ItemId = 5, Name = "FarmWidget", ItemCost = 5.92m, ItemPrice = 12.99m, Stock = 32},
            new Item(){ ItemId = 6, Name = "PetWidget", ItemCost = 0.42m, ItemPrice = 2.50m, Stock = 32},
        };

        foreach (Item i in items)
        {
            context.Items.Add(i);
        }

        context.SaveChanges();
        }
    }
}
