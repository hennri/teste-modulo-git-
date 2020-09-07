using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Etec.ConsultorioMedico.UI;

namespace Etec.ConsultorioMedico.UI
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnPaciente_Click(object sender, EventArgs e)
        {
            Paciente paci = new Paciente();
            paci.Show();
        }

        private void btnMedico_Click(object sender, EventArgs e)
        {
            Medico medico = new Medico();
            medico.Show();
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            Funcionario func = new Funcionario();
            func.Show();
        }

        private void btnPlanoMedico_Click(object sender, EventArgs e)
        {
            PlanoMedico planoM = new PlanoMedico();
            planoM.Show();
        }

        private void btnCadEspecialidades_Click(object sender, EventArgs e)
        {
            CadastroEspecialidades cadEs = new CadastroEspecialidades();
            cadEs.Show();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            Consulta consu = new Consulta();
            consu.Show();
        }
    }
}
