using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Etec.ConsultorioMedico.CLASS;
using System.Data.SqlClient;
using System.Data;

namespace Etec.ConsultorioMedico.DATA
{
   public class FuncionarioDATA
    {
        public List<Funcionario> buscarFuncionario()
        {



            string banco = "User ID=sa;Password=1234567;Data Source=PC04-LAB3;Database=ConsultorioMedico";

            SqlConnection validBanco = new SqlConnection(banco);

            validBanco.Open();

            SqlCommand comando = new SqlCommand("select * from tbFuncionario", validBanco);

            SqlDataReader executar = comando.ExecuteReader();

            List<Funcionario> listaFuncionario = new List<Funcionario>();

            while (executar.Read())
            {
                Funcionario itemFuncionario = new Funcionario();

                itemFuncionario.idFuncionario = int.Parse(executar["idFuncionario"].ToString());
                itemFuncionario.Nome = executar["Nome"].ToString();
                itemFuncionario.Cpf = int.Parse(executar["Cpf"].ToString());
                itemFuncionario.Cargo = executar["Cargo"].ToString();
                itemFuncionario.Telefone = int.Parse(executar["Telefone"].ToString());
                itemFuncionario.Endereco = executar["Endereco"].ToString();
                itemFuncionario.Turno = executar["Turno"].ToString();

                listaFuncionario.Add(itemFuncionario);
            }

            validBanco.Close();

            return listaFuncionario;



        }
       
    }
}
