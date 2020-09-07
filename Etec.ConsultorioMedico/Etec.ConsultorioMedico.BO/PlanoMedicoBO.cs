using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Etec.ConsultorioMedico.CLASS;
using Etec.ConsultorioMedico.DATA;

namespace Etec.ConsultorioMedico.BO
{
   public class PlanoMedicoBO
    {
        public List<PlanoMedico> buscarPlanoMedico()
        {
            PlanoMedicoDATA Data = new PlanoMedicoDATA();

            return Data.buscarPlanoMedico();

        }
    }
}
