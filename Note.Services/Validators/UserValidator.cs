using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using FluentValidation;
using Note.DAL.Models;

namespace Note.Services.Validators
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(user => user.Name)
                .Length(4, 15)
                .WithErrorCode(nameof(HttpStatusCode.BadRequest))
                .WithMessage("Введите больше 4 символов");
            RuleFor(user => user.Email)
                .EmailAddress()
                .WithErrorCode(nameof(HttpStatusCode.BadRequest))
                .WithMessage("email введен не коректно");
            RuleFor(user => user.Password)
                .NotEmpty()
                .WithErrorCode(nameof(HttpStatusCode.BadRequest))
                .WithMessage("Пароль должен иметь только числа");
        }
    }
}
