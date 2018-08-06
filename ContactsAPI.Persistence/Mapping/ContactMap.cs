using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ContactsAPI.DomainModel;

namespace ContactsAPI.Persistence.Mapping
{
    public class ContactMap : IEntityTypeConfiguration<Contact>
    {
        /// <summary>
        /// Configures the entity of type <typeparamref name="TEntity" />.
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            //table name
            builder.ToTable("Contact");

            //constraints and indices
            builder.HasKey(item => item.Id);
            builder.HasIndex(item => item.Email).IsUnique();
            builder.HasIndex(item => item.PhoneNumber).IsUnique();
            builder.HasIndex(item => new { item.Email, item.PhoneNumber }).IsUnique();

            //type mapping
            builder.Property(item => item.FirstName).HasColumnType("VARCHAR(30)").IsRequired();
            builder.Property(item => item.MiddleName).HasColumnType("VARCHAR(30)");
            builder.Property(item => item.LastName).HasColumnType("VARCHAR(30)").IsRequired();
            builder.Property(item => item.Email).HasColumnType("VARCHAR(100)").IsRequired();
            builder.Property(item => item.PhoneNumber).HasColumnType("VARCHAR(30)").IsRequired();
            builder.Property(item => item.Status);
            builder.Property(item => item.CreatorRID).IsRequired();
            builder.Property(item => item.CreationDate).IsRequired();
        }
    }
}
