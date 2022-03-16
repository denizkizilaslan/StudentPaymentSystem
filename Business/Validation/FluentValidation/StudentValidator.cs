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
    public class StudentValidator : AbstractValidator<Student>
    {
        public StudentValidator()
        {
            RuleFor(u => u.SchoolId).GreaterThanOrEqualTo(1).WithMessage(ValidationMessage.RequiredField);
            RuleFor(u => u.Name).NotNull().MaximumLength(5).WithMessage(ValidationMessage.MaxLengthField);
            RuleFor(u => u.Surname).NotNull().MaximumLength(100).WithMessage(ValidationMessage.MaxLengthField);
            RuleFor(u => u.TcNumber).NotNull().MaximumLength(11).WithMessage(ValidationMessage.MaxLengthField);
            RuleFor(u => u.StudentNumber).NotNull().MaximumLength(20).WithMessage(ValidationMessage.MaxLengthField);
        }
    }
}
