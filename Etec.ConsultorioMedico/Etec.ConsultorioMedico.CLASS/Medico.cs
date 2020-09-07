using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etec.ConsultorioMedico.CLASS
{
   public class Medico : Funcionario
    {
       public int idMedico { get; set; }
       public int Crm { get; set; }  
       public int status { get; set; }

        public List<Especialidades> listaEspecialidades { get; set; }

       

        
    }

}
