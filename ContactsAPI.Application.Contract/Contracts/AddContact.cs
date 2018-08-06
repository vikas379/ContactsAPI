using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace ContactsAPI.Application.Contract.Contracts
{
    public class AddContact : ContactCommand
    {
        /// <summary>
        /// Gets or sets the creator rid.
        /// </summary>
        /// <value>
        /// The creator rid.
        /// </value>
        public int CreatorRID { get; set; }

    }
}
