using System;
using System.Collections.Generic;
using System.Text;

namespace ContactsAPI.Application.Contract.Contracts
{
    public class BaseModel
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the creation date.
        /// </summary>
        /// <value>
        /// The creation date.
        /// </value>
        public DateTime CreationDate { get; set; }

        /// <summary>
        /// Gets or sets the modification date.
        /// </summary>
        /// <value>
        /// The modification date.
        /// </value>
        public DateTime? ModificationDate { get; set; }

        /// <summary>
        /// Gets or sets the creator rid.
        /// </summary>
        /// <value>
        /// The creator rid.
        /// </value>
        public int CreatorRID { get; set; }

        /// <summary>
        /// Gets or sets the modifier rid.
        /// </summary>
        /// <value>
        /// The modifier rid.
        /// </value>
        public int ModifierRID { get; set; }

    }
}
