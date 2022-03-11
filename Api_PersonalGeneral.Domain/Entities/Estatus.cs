//cSpell: disable

using System;
using System.Collections.Generic;

#nullable disable

namespace Api_PersonalGeneral.Domain.Entities
{
    public partial class Estatus
    {
        public Estatus()
        {
            Cursos = new HashSet<Curso>();
        }

        public int IdEstatus { get; set; }
        public string Estado { get; set; }

        public virtual ICollection<Curso> Cursos { get; set; }
    }
}
