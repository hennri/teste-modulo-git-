using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Etec.ConsultorioMedico.CLASS;
using System.Data.SqlClient;

namespace Etec.ConsultorioMedico.DATA
{
   public class EspecialidadesDATA
    {
        public List<Especialidades> buscarEspecialidade()
        {
            string banco = "User ID=sa;Password=1234567;Data Source=PC04-LAB3;Database=ConsultorioMedico";


            SqlConnection validbanco = new SqlConnection(banco);


            validbanco.Open();


            SqlCommand comando = new SqlCommand("select * from tbEspecialidades", validbanco);


            SqlDataReader executar = comando.ExecuteReader();


            List<Especialidades> listaEspecialidades = new List<Especialidades>();


            while (executar.Read())
            {
                Especialidades itemEspecialidades = new Especialidades();

                itemEspecialidades.idEspecialidade = int.Parse(executar["idEspecialidade"].ToString());
                itemEspecialidades.NomeEspecialidade = executar["NomeEspecialidade"].ToString();
                itemEspecialidades.Atividade = executar["Atividade"].ToString();

                listaEspecialidades.Add(itemEspecialidades);
            }

            //fechando a conexão
            validbanco.Close();

            return listaEspecialidades;


        }
    }
}
