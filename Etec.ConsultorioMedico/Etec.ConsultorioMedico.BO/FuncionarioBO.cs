using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Etec.ConsultorioMedico.CLASS;
using Etec.ConsultorioMedico.DATA;

namespace Etec.ConsultorioMedico.BO
{
  public class FuncionarioBO
    {
        public List <Funcionario> buscarFuncionario()
        {
            FuncionarioDATA Data = new FuncionarioDATA();

            return Data.buscarFuncionario();
        }
    }
}
