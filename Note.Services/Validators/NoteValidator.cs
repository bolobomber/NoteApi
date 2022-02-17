using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace Note.Services.Validators
{
    public class NoteValidator : AbstractValidator<DAL.Models.Note>
    {
        public NoteValidator()
        {
            RuleFor(note => note.Title)
                .Length(1, 25)
                .WithErrorCode(nameof(HttpStatusCode.BadRequest))
                .WithMessage("Введите больше 1 символa");
        }
    }
}
