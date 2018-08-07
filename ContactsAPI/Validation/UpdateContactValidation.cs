using ContactsAPI.Application.Contract.Contracts;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactsAPI.Validation
{
    public class UpdateContactValidator : ContactCommandValidator<UpdateContact>
    {
        public UpdateContactValidator()
        {
            RuleFor(c => c.ModifierRID)
                .NotEmpty().WithMessage("Modifier rid is required")
                .GreaterThan(0).WithMessage("Modifier rid should be greater than 0");

            RuleFor(c => c.Id)
                .NotEmpty().WithMessage("Id is required")
                .GreaterThan(0).WithMessage("Id should be greater than 0");
        }
    }
}
