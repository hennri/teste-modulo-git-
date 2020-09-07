using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Etec.ConsultorioMedico.DATA;
using Etec.ConsultorioMedico.CLASS;

namespace Etec.ConsultorioMedico.BO
{
   public class EspecialidadesBO
    {
        public List<Especialidades> buscarEspecialidades()
        {
            EspecialidadesDATA Data = new EspecialidadesDATA();

            return Data.buscarEspecialidade();
        }
    }
}
