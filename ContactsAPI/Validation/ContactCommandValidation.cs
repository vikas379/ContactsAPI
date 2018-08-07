using ContactsAPI.Application.Contract.Contracts;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactsAPI.Validation
{
    public class ContactCommandValidator<T> : AbstractValidator<T> where T : ContactCommand
    {
        public ContactCommandValidator()
        {
            RuleFor(c => c.FirstName)
                .NotEmpty().WithMessage("First name is required")
                .MaximumLength(30).WithMessage("First name cannot have more than 30 characters");

            RuleFor(c => c.MiddleName)
                .MaximumLength(30).WithMessage("Middle name cannot have more than 30 characters");

            RuleFor(c => c.LastName)
                .NotEmpty().WithMessage("Last name is required")
                .MaximumLength(30).WithMessage("Last name cannot have more than 30 characters");

            RuleFor(c => c.Email)
                .NotEmpty().WithMessage("Email is required")
                .EmailAddress().WithMessage("Invalid Email Address")
                .MaximumLength(100).WithMessage("Email cannot have more than 100 characters");

            RuleFor(c => c.PhoneNumber)
                .NotEmpty().WithMessage("Phone number is required")
                .Matches(@"\s*(?:\+?(\d{1,3}))?([-. (]*(\d{3})[-. )]*)?((\d{3})[-. ]*(\d{2,4})(?:[-.x ]*(\d+))?)\s*").WithMessage("Invalid phone number")
                .MaximumLength(30).WithMessage("Phone number cannot have more than 30 characters");

            RuleFor(c => c.Status)
                .Must((c) =>
                {
                    if (c == "Active")
                        return true;
                    if (c == "Inactive")
                        return true;
                    else return false;
                }).WithMessage("Status can either be Active or Inactive")
                .NotEmpty().WithMessage("Status is required");

        }
    }
}
