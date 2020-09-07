using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etec.ConsultorioMedico.CLASS
{
    public class Consulta : Paciente
    {
        public int idConsulta { get; set; }
        public int idPaciente { get; set; }
        public Paciente PacienteConsulta { get; set; }
        public Medico MedicoConsulta { get; set; }
        public string Agenda { get; set; }
        public string TipoConsulta { get; set; }
        
    }
}
