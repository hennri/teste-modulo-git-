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
    public partial class Medico : Form
    {
        public Medico()
        {
            InitializeComponent();
        }

   

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void lblEspecialidade_Click(object sender, EventArgs e)
        {

        }



        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Etec.ConsultorioMedico.CLASS.Medico classeMedico = new ConsultorioMedico.CLASS.Medico();
            classeMedico.Crm = int.Parse(txtCrm.Text);
        }

        private void Medico_Load(object sender, EventArgs e)
        {
            MedicoBO regra = new MedicoBO();
            dtMedico.DataSource = regra.buscarMedico(); 
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MedicoBO regra = new MedicoBO();
            dtMedico.DataSource = regra.buscarMedico();

        }
    }
}
