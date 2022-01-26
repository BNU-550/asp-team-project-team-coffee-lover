using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoffeeLover.Models
{
    /// <summary>
    /// Creates the base to create a product. This is then going to be
    /// bought by users and ordered.
    /// </summary>
    public class Products
    {
        /// <summary>
        /// The ID of a product
        /// </summary>
        [DisplayName("Product ID"), Required, Key,]
        public string? ProductID { get; set; }

        /// <summary>
        /// The name of the product.
        /// </summary>
        [DisplayName("Product name"), Required, StringLength(maximumLength: 20)]
        public string? ProductName { get; set; }


        /// <summary>
        /// Description of the product
        /// </summary>
        [DisplayName("Description"), Required]
        public string? Description { get; set; }

        public string? ImageURL { get; set; }


        /// <summary>
        /// The price is set for the item.
        /// </summary>
        [DisplayName("Price"), Required]
        [Column(TypeName = "Money")]
        public decimal Price { get; set; }

        /// <summary>
        /// Supplier's ID is recorded for reference.
        /// </summary>
        [DisplayName("Supplier ID"), Required]
        public int SupplierID { get; set; }

        public virtual Products? Product { get; set; }
    }
}