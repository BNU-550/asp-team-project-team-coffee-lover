using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

/// <summary>
/// Information on the order that the cashier is processing is recorded,
/// and then the details of the cashier is also recorded.
/// </summary>
namespace CoffeeLover.Models
{
    public class Cashier
    {
        /// <summary>
        /// Order item's ID is made.
        /// </summary>
        [DisplayName("Order ID"), Required]
        public int OrderItemsOrderID { get; set; }

        /// <summary>
        /// The product's ID is recorded.
        /// </summary>
        [DisplayName("Order products ID"), Required]
        public int OrderItemsProductsID { get; set; }

        /// <summary>
        /// Staff's ID.
        /// </summary>
        [DisplayName("Staff ID"), Required, Key]
        public int StaffID { get; set; }

        /// <summary>
        /// Cashier's first name.
        /// </summary>
        [DisplayName("First name"), Required, StringLength(maximumLength: 15)]
        public string? FirstName { get; set; }

        /// <summary>
        /// Cashier's last name
        /// </summary>
        [DisplayName("Last name"), Required, StringLength(maximumLength: 15)]
        public string? LastName { get; set; }

        /// <summary>
        /// Cashier's email.
        /// </summary>
        [DisplayName("Email"), Required, StringLength(maximumLength: 30)]
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }
    }
}