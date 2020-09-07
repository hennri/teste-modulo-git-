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
    public class PacienteDATA
    {
        public List<Paciente> buscarPaciente()
        {
            //conexão com banco de dados
            string chave = "User ID=sa;Password=1234567;Data Source=PC04-LAB3;Database=ConsultorioMedico";

            //validar conexão com banco de dados
            SqlConnection carro = new SqlConnection(chave);
            
            //abrir conexão com banco de dados
            carro.Open();

            //preencher o comando sql 
            SqlCommand partida = new SqlCommand("select * from tbPaciente where idPaciente = 1", carro);

            //executar comando sql - F5
            SqlDataReader acelerar = partida.ExecuteReader();


            //ARRAY(LISTA) DE PACIENTES
            List<Paciente> listaPacientes = new List<Paciente>();


            //LOOP SEM CONTADOR 
            while (acelerar.Read())
            {
                Paciente itemPaciente = new Paciente();
                
                itemPaciente.idPaciente = int.Parse(acelerar["idPaciente"].ToString());
                itemPaciente.Nome = acelerar["nmPaciente"].ToString();
                itemPaciente.Endereco =  acelerar["dsEndereco"].ToString();

                listaPacientes.Add(itemPaciente);
            }

            carro.Close();

            return listaPacientes;
        }
    }
}
