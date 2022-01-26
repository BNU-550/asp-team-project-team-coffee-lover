using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

/// <summary>
/// The customer is able to create an account. They need to fill in all
/// of the details so we can properly contact them.
/// </summary>
namespace CoffeeLovers.Models
{
    public class Customer
    {
        /// <summary>
        /// Customer's first name is recorded.
        /// </summary>
        [DisplayName("First name"), Required, StringLength(maximumLength: 15)]
        public string? FirstName { get; set; }

        /// <summary>
        /// The ID for the user.
        /// </summary>
        [DisplayName("ID"), Key, Required]
        public int ID { get; set; }

        /// <summary>
        /// Customer's last name is recorded.
        /// </summary>
        [DisplayName("Last name"), Required, StringLength(maximumLength: 15)]
        public string? LastName { get; set; }

        /// <summary>
        /// Email address is recorded.
        /// </summary>
        [DisplayName("Email"), Required, StringLength(maximumLength: 30)]
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }

        /// <summary>
        /// Date is recorded of user sign up.
        /// </summary>
        [Required]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        /// <summary>
        /// User's address is recorded for deliveries.
        /// </summary>
        [DisplayName("Address"), Required, StringLength(maximumLength: 30)]
        public string? Address { get; set; }

        /*
         * User's phone number is recorded in case of imidate contact.
         */
        [DisplayName("Phone number"), Required]
        [DataType(DataType.PhoneNumber)]
        public string? PhoneNumber { get; set; }
    }
}