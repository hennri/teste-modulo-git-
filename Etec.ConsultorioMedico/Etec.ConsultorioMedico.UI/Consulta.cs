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
    public partial class Consulta : Form
    {
        public Consulta()
        {
            InitializeComponent();
        }

        private void lblPaciente_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Etec.ConsultorioMedico.CLASS.Consulta classeConsulta = new CLASS.Consulta();
            classeConsulta.TipoConsulta = txtTipoConsulta.Text;
        }

        private void Consulta_Load(object sender, EventArgs e)
        {
            ConsultaBO regra = new ConsultaBO();
            dtConsulta.DataSource = regra.buscarConsulta();

        }
    }
}
