//cSpell: disable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;
using Api_PersonalGeneral.Domain.DTOS.requests;
using Api_PersonalGeneral.Domain.Interfaces;

namespace Api_PersonalGeneral.Infraestructure.Validators
{
    public class AlumnoValidator : AbstractValidator<AlumnoRequest>
    {
        private readonly IalumnoInterface _repository;

        public AlumnoValidator(IalumnoInterface repository)
        {
            this._repository = repository;

            RuleFor(c => c.NombreCompleto).NotNull().NotEmpty().Length(5,40);
            RuleFor(c => c.Correo).Must(CorreoNoExistente).NotNull().NotEmpty().EmailAddress().WithMessage("Correo electronico incorrecto. Hace falta '@'?");
            RuleFor(c => c.Clave).NotNull().NotEmpty();

        
        }

        public bool CorreoNoExistente(string correo) 
        {
            return !_repository.Exist(c => c.Correo == correo);
        }
    }
}