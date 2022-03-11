//cSpell:disable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_PersonalGeneral.Domain.DTOS.requests
{
    public class CursoRequests
    {
        public string Titulo { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaCierre { get; set; }
        public string LinkReunion { get; set; }
        public string Material { get; set; }
        public string Descripcion { get; set; }
        public int IdProfesor { get; set; }
        public int IdEstatus {get; set; }
    }
}