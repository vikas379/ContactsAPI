using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;


namespace ContactsAPI.Application.Contract.Contracts
{
    public class ContactCommand
    {
        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        /// <value>
        /// The first name.
        /// </value>
        [Required(ErrorMessage = "First name is required")]
        [MaxLength(30, ErrorMessage = "First name cannot have more than 30 characters")]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the name of the middle.
        /// </summary>
        /// <value>
        /// The name of the middle.
        /// </value>
        [MaxLength(30, ErrorMessage = "Middle name cannot have more than 30 characters")]
        public string MiddleName { get; set; }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        /// <value>
        /// The last name.
        /// </value>
        [Required(ErrorMessage = "Last name is required")]
        [MaxLength(30, ErrorMessage = "Last name cannot have more than 30 characters")]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        /// <value>
        /// The email.
        /// </value>
        [Required(ErrorMessage = "Email is required")]
        [MaxLength(100, ErrorMessage = "Email address cannot have more than 100 characters")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the phone number.
        /// </summary>
        /// <value>
        /// The phone number.
        /// </value>
        [Required(ErrorMessage = "Phone number is required")]
        [MaxLength(100, ErrorMessage = "phone number cannot have more than 30 characters")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Contacts"/> is status.
        /// </summary>
        /// <value>
        ///   <c>true</c> if status; otherwise, <c>false</c>.
        /// </value>
        public bool Status { get; set; }
    }
}
