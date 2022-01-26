using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

/// <summary>
/// The supplier and their contact details are recorded.
/// </summary>
namespace CoffeeLover.Models
{
    public class Supplier
    {
        [DisplayName("Supplier ID"), Key, Required]
        public int SupplierID { get; set; }

        /// <summary>
        /// Supplier's company name.
        /// </summary>
        [DisplayName("Company name"), Required, StringLength(maximumLength: 15)]
        public String? Name { get; set; }

        /// <summary>
        /// Phone number for the supplier.
        /// </summary>
        [DisplayName("Phone number"), Required]
        [DataType(DataType.PhoneNumber)]
        public string Contact { get; set; }

        /// <summary>
        /// Email address for the supplier.
        /// </summary>
        [DisplayName("Email"), Required]
        [DataType(DataType.EmailAddress)]
        public String? Email { get; set; }
    }
}