using System;
using System.ComponentModel.DataAnnotations;

namespace ContactsAPI.DomainModel
{
    public class Entity
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        [Key]
        public int Id { get; protected set; }
        /// <summary>
        /// Gets or sets the creation data.
        /// </summary>
        /// <value>
        /// The creation data.
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
