using ContactsAPI.Application.Contract.Contracts;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactsAPI.Validation
{
    public class AddContactValidator : ContactCommandValidator<AddContact>
    {
        public AddContactValidator()
        {
            RuleFor(c => c.CreatorRID)
                .NotEmpty().WithMessage("Creator rid is required")
                .GreaterThan(0).WithMessage("Creator rid should be a positive integer");

        }
    }
}
