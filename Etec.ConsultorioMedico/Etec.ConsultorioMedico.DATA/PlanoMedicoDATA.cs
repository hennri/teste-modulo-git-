using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Etec.ConsultorioMedico.CLASS;
using System.Data.SqlClient;
using System.Data;

namespace Etec.ConsultorioMedico.DATA
{
   public class PlanoMedicoDATA
    {
        public List<PlanoMedico> buscarPlanoMedico()
        {
            string banco = "User ID=sa;Password=1234567;Data Source=PC04-LAB3;Database=ConsultorioMedico";


            SqlConnection validbanco = new SqlConnection(banco);


            validbanco.Open();


            SqlCommand comando = new SqlCommand("select * from tbPlanoMedico", validbanco);


            SqlDataReader executar = comando.ExecuteReader();


            List<PlanoMedico> listaPlanoMedico = new List<PlanoMedico>();


            while (executar.Read())
            {
                PlanoMedico itemPlanoMedico = new PlanoMedico();

                itemPlanoMedico.idPlano = int.Parse(executar["idPlano"].ToString());
                itemPlanoMedico.Titular = executar["titular"].ToString();
                itemPlanoMedico.Empresa = executar["Empresa"].ToString();


                listaPlanoMedico.Add(itemPlanoMedico);
            }

            //fechando a conexão
            validbanco.Close();

            return listaPlanoMedico;
        }
    }
}
