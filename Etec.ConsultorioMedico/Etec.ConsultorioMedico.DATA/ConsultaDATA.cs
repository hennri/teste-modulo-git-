using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Etec.ConsultorioMedico.CLASS;
using System.Data.SqlClient;

namespace Etec.ConsultorioMedico.DATA
{
    public class ConsultaDATA
    {
        public List <Consulta> buscarConsulta()
        {
            string banco = "User ID=sa;Password=1234567;Data Source=PC04-LAB3;Database=ConsultorioMedico";


            SqlConnection validbanco = new SqlConnection(banco);


            validbanco.Open();


            SqlCommand comando = new SqlCommand("select * from tbConsulta", validbanco);


            SqlDataReader executar = comando.ExecuteReader();


            List<Consulta> listaConsulta = new List<Consulta>();


            while (executar.Read())
            {
                Consulta itemConsulta = new Consulta();

                itemConsulta.idConsulta = int.Parse(executar["idConsulta"].ToString());
                itemConsulta.idPaciente = int.Parse(executar["idPaciente"].ToString());
                itemConsulta.Agenda =  executar["Agenda"].ToString();
                itemConsulta.TipoConsulta = executar["TipoConsulta"].ToString();
             
                listaConsulta.Add(itemConsulta);
            }

            //fechando a conexão
            validbanco.Close();

            return listaConsulta;

        }
    }
}
