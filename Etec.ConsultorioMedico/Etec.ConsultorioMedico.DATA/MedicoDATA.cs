using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Etec.ConsultorioMedico.CLASS;
using System.Data;
using System.Data.SqlClient;

namespace Etec.ConsultorioMedico.DATA
{
    public class MedicoDATA
    {
        public List <Medico> buscarMedico()
        {
            
            string banco = "User ID=sa;Password=1234567;Data Source=PC04-LAB3;Database=ConsultorioMedico";
            
            
            SqlConnection validbanco = new SqlConnection(banco);

            
            validbanco.Open();

            
            SqlCommand comando = new SqlCommand("select * from tbMedico", validbanco);

            
            SqlDataReader executar = comando.ExecuteReader();

           
            List<Medico> listaMedico = new List<Medico>();

            
            while (executar.Read())
            {
                Medico itemMedico = new Medico();

                itemMedico.idMedico = int.Parse(executar["idMedico"].ToString());
                itemMedico.Crm = int.Parse(executar["Crm"].ToString());
                itemMedico.status = int.Parse(executar["status"].ToString());

                listaMedico.Add(itemMedico);
            }

            //fechando a conexão
            validbanco.Close();

            return listaMedico;
                

        }
    }
}
