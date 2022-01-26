using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

/// <summary>
/// Orders of the items are recorded and checks how much
/// of each of the products are desired.
/// </summary>
namespace CoffeeLover.Models
{
    public class OrderItems
    {
        [DisplayName("Order ID"), Key]
        public int OrderID { get; set; }


        /// <summary>
        /// Total price of the items together.
        /// </summary>
        [DisplayName("Price"), Required]
        public decimal Price { get; set; }

        /// <summary>
        /// Get multiple of an item.
        /// </summary>
        [DisplayName("Quantity"), Required]
        public int Quantity { get; set; }
    }
}