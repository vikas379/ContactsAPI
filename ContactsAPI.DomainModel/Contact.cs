using System;
using System.Collections.Generic;
using System.Text;

namespace ContactsAPI.DomainModel
{
    public class Contact: Entity
    {
        public Contact(int id, string firstName, string middleName, string lastName, string email, string phoneNumber, string status, int createorRID, int modifierRID)
        {
            Id = id;
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
            Status = status;
            CreatorRID = createorRID;
            ModifierRID = modifierRID;
        }

        public Contact() { }

        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        /// <value>
        /// The first name.
        /// </value>
        public string FirstName { get; set; }
        /// <summary>
        /// Gets or sets the name of the middle.
        /// </summary>
        /// <value>
        /// The name of the middle.
        /// </value>
        public string MiddleName { get; set; }
        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        /// <value>
        /// The last name.
        /// </value>
        public string LastName { get; set; }
        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        /// <value>
        /// The email.
        /// </value>
        public string Email { get; set; }
        /// <summary>
        /// Gets or sets the phone number.
        /// </summary>
        /// <value>
        /// The phone number.
        /// </value>
        public string PhoneNumber { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="Contact"/> is status.
        /// </summary>
        /// <value>
        ///   <c>true</c> if status; otherwise, <c>false</c>.
        /// </value>
        public string Status { get; set; }

    }
}
