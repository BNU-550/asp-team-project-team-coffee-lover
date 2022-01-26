using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using System.Linq;
using System.Threading.Tasks;

/// <summary>
/// Customer's card details are recorded, this is going to be used
/// when an order is going to be made.
/// </summary>
namespace CoffeeLover.Models
{
    public class Customer_Payment_Method
    {

        [Required, Key]
        public int PaymentMethodCode { get; set; }

        /// <summary>
        /// Card's number is recorded for the payment method.
        /// </summary>

        [Required, StringLength(maximumLength: 16)]
        [DataType(DataType.CreditCard)]
        public string ?CardNumber { get; set; }

        /// <summary>
        /// Date of the purchase is taken.
        /// </summary>

        [Required]
        public DateTime DateOfPurcahse { get; set; }
        [DataType(DataType.Time)]

        /// <summary>
        /// Total price of the items is then wrote down.
        /// </summary>

        [Required]
        [Column(TypeName = "Money")]
        public decimal Total { get; set; }

        /// <summary>
        /// The bill number is made.
        /// </summary>
        [Required]
        public int BillNumber { get; set; }
    }
}