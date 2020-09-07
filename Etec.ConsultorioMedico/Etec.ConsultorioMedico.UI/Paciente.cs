using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Etec.ConsultorioMedico.CLASS;
using Etec.ConsultorioMedico.BO;


namespace Etec.ConsultorioMedico.UI
{
    public partial class Paciente : Form
    {
        public Paciente()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Paciente_Load(object sender, EventArgs e)
        {
            PacienteBO regraNegocio = new PacienteBO();
            dtPaciente.DataSource = regraNegocio.buscarPaciente();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Etec.ConsultorioMedico.CLASS.Paciente classePaciente = new ConsultorioMedico.CLASS.Paciente();
            classePaciente.Nome = txtNomeDoPaciente.Text;
        }
    }
}
