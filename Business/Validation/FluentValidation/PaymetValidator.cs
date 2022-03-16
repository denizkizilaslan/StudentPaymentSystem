using Common.Messages;
using Entities.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Validation.FluentValidation
{
    public class PaymetValidator:AbstractValidator<StudentPayment>
    {
        public PaymetValidator()
        {
            RuleFor(u => u.StudentId).NotNull().WithMessage(ValidationMessage.RequiredField);
            RuleFor(u => u.Total).NotNull().WithMessage(ValidationMessage.RequiredField);
        }
    }
}
