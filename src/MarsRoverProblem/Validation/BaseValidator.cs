using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRoverProblem
{
    public class BaseValidator<T> : AbstractValidator<T>
    {
        public new ValidationResult Validate(T instance, string property)
        {
            ValidationResult validationResult;

            if (object.Equals(instance, default(T)))
            {
                validationResult = new ValidationResult(new[] { new ValidationFailure(property, $"{property} Can Not Be Empty") });
            }
            else
            {
                validationResult = base.Validate(instance);
            }


            return validationResult;
        }
    }
}
